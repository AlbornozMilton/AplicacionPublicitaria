using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class AgregarBanner : Form
	{
		//private List<Banner> iBannersEnRan;
		private ControladorExtra iControlExtra = new ControladorExtra();
		private List<IFuente> iFuentes = new List<IFuente>();
		private string iDias;

		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			iFuentes = new ControladorBanner().ObtenerFuentes();// solo nombres de fuente
			foreach (IFuente fuente in iFuentes)
			{
				cbx_Fuente.Items.Add(fuente.NombreFuente);
			}
		}

		private void btnAgregarHorario_Click(object sender, EventArgs e)
		{
			ControlHorarios();
		}

		private void btnBorrarHorario_Click(object sender, EventArgs e)
		{
			if (dGV_itemsFuente.CurrentRow != null)
			{
				//lista de horarios eliminar donde el current row sea igual
				dGV_itemsFuente.Rows.Remove(dGV_itemsFuente.CurrentRow);
			}

			//if (dGV_horarios.Rows.Count == 0)
			//	cbx_Fuente.Enabled = false;
			//else
			//	cbx_Fuente.Enabled = true;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (tbxNombreBanner.Text == "")
					throw new Exception("Debe rellenar el campo Nombre");

				if (iDias == null)
					throw new Exception("Debe elegir al menos un Día");

				if (dGV_horarios.Rows.Count == 0)
					throw new Exception("Debe elegir al menos un Horario");

				if (dGV_itemsFuente.Rows.Count == 0)
					throw new Exception("Debe elegir una Fuente que contenga al menos un Item");

				// borra ultimo guion para que futuro Split('-') no genere un item string vacio
				iDias = iDias.Remove(iDias.Length - 1);

				List<RangoHorario> ListaRangoH = new List<RangoHorario>();
				foreach (DataGridViewRow item in dGV_horarios.Rows)
				{
					var desde = (TimeSpan)item.Cells[0].Value;
					var hasta = (TimeSpan)item.Cells[1].Value;
					ListaRangoH.Add(new RangoHorario(new TimeSpan(desde.Hours, desde.Minutes, 0), new TimeSpan(hasta.Hours, hasta.Minutes, 0)));
				}

				new ControladorBanner().AgregarBanner(tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, ListaRangoH, iDias);

				new VentanaEmergente("Banner Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				Close();
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnFuentes_Click(object sender, EventArgs e)
		{
			new Fuentes(cbx_Fuente.SelectedText, iFuentes).ShowDialog();
		}

		private void ControlFecha(object sender, EventArgs e)
		{
			try
			{
				//gbxFuentes.Enabled = false;
				if (fechaHasta.Value.Date <= fechaDesde.Value.Date)
				{
					//gbxDias.Enabled = false;
					//gbxHorarios.Enabled = false;
					throw new Exception("La Fecha Desde tiene que ser mayor que la Fecha Hasta");
				}

				dGV_horarios.Rows.Clear();
				iControlExtra.ActualizarBannersEnRangoFecha(fechaDesde.Value, fechaHasta.Value);
				//gbxDias.Enabled = true;
				//gbxHorarios.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ControlHorarios()
		{
			try
			{
				TimeSpan desde, hasta;
				desde = new TimeSpan(horaDesde.Value.Hour, horaDesde.Value.Minute, 0);
				hasta = new TimeSpan(horaHasta.Value.Hour, horaHasta.Value.Minute, 0);

				if (desde.CompareTo(hasta) >= 0)
				{
					throw new Exception("La Hora Desde tiene que ser menor que la Hora Hasta");
				}

				foreach (DataGridViewRow row in dGV_horarios.Rows)
				{
					if ((((TimeSpan)row.Cells[0].Value).CompareTo(desde) >= 0 && ((TimeSpan)row.Cells[0].Value).CompareTo(hasta) <= 0)
						||
						(((TimeSpan)row.Cells[1].Value).CompareTo(desde) >= 0 && ((TimeSpan)row.Cells[0].Value).CompareTo(hasta) <= 0))
					throw new Exception("El Horario elegido intersecta con los elegidos recientemente");
				}

				////cotrol de que no halla interseccion en los banners de bd
				iControlExtra.ComprobarHorarioBanner(desde, hasta, iDias);

				//agregar horario a la lista de horario o al controlador
				dGV_horarios.Rows.Add(desde, hasta);

				//if (dGV_horarios.Rows.Count == 0)
				//	gbxFuentes.Enabled = false;
				//else
				//	gbxFuentes.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_luenes.Checked)
				iDias += "lunes-";
			else
				iDias = iDias.Replace("lunes-", "");
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
				iDias += "martes-";
			else
				iDias = iDias.Replace("martes-", "");
		}

		private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_miercoles.Checked)
				iDias += "miercoles-";
			else
				iDias = iDias.Replace("miercoles-", "");
		}

		private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_jueves.Checked)
				iDias += "jueves-";
			else
				iDias = iDias.Replace("jueves-", "");
		}

		private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_viernes.Checked)
				iDias = iDias += "viernes-";
			else
				iDias = iDias.Replace("viernes-", "");
		}

		private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_sabado.Checked)
				iDias += "sabado-";
			else
				iDias = iDias.Replace("sabado-", "");
		}

		private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_domingo.Checked)
				iDias += "domingo-";
			else
				iDias = iDias.Replace("domingo-", "");
		}

		private void HoverLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true)[0].Visible = true;
		}

		private void LeaveLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true).First().Visible = false;
		}

		private void cbx_FuenteRss_SelectedIndexChanged(object sender, EventArgs e)
		{
			IFuente _Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			txbTipoFuente.Text = _Fuente.GetType().Name;

			if (txbTipoFuente.Text != "FuenteRSS")
			{
				//btnAgregarItem.Visible = true;
				//btnModificarFuente.Visible = true;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteTexto(_Fuente.FuenteId);
			}
			else
			{
				//btnAgregarItem.Visible = false;
				//btnModificarFuente.Visible = false;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteRss(_Fuente.FuenteId);
			}
		}
	}
}