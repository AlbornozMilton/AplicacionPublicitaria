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
		List<RangoHorario> iHorarios = new List<RangoHorario>();
		private ControladorExtra iControlExtra = new ControladorExtra();
		private List<IFuente> iFuentes = new List<IFuente>();
		private string iDias;

		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			RellenarFuentes();
		}

		private void RellenarFuentes()
		{
			cbx_Fuente.Items.Clear();
			iFuentes = new ControladorBanner().ObtenerFuentes();
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
			if (dGV_horarios.CurrentRow != null)
			{
				dGV_horarios.Rows.Remove(dGV_itemsFuente.CurrentRow);

				iHorarios.RemoveAt(dGV_itemsFuente.CurrentRow.Index);

				//iHorarios.Remove(iHorarios.Find
				//		(h => h.HoraInicio == ((TimeSpan)dGV_itemsFuente.CurrentRow.Cells[0].Value)
				//		&& h.HoraFin == ((TimeSpan)dGV_itemsFuente.CurrentRow.Cells[1].Value)));
			}
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

				//List<RangoHorario> ListaRangoH = new List<RangoHorario>();
				//foreach (DataGridViewRow item in dGV_horarios.Rows)
				//{
				//	var desde = (TimeSpan)item.Cells[0].Value;
				//	var hasta = (TimeSpan)item.Cells[1].Value;
				//	ListaRangoH.Add(new RangoHorario(new TimeSpan(desde.Hours, desde.Minutes, 0), new TimeSpan(hasta.Hours, hasta.Minutes, 0)));
				//}

				new ControladorBanner().AgregarBanner(tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios, iDias);

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
			RellenarFuentes();
		}

		private void ControlFecha(object sender, EventArgs e)
		{
			try
			{
				if (fechaHasta.Value.Date <= fechaDesde.Value.Date)
				{
					throw new Exception("La Fecha Desde tiene que ser mayor que la Fecha Hasta");
				}

				dGV_horarios.Rows.Clear();
				iHorarios.Clear();
				iControlExtra.ActualizarBannersEnRangoFecha(fechaDesde.Value, fechaHasta.Value);
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
					throw new Exception("La Hora Desde tiene que ser menor que la Hora Hasta");

				foreach (RangoHorario item in iHorarios)
				{
					if (!(item.HoraInicio.CompareTo(desde) > 0 && item.HoraInicio.CompareTo(hasta) > 0)
						&&
						(!(item.HoraFin.CompareTo(desde) < 0 && item.HoraFin.CompareTo(hasta) < 0)))
						throw new Exception("El Horario elegido intersecta con los elegidos recientemente");
				}

				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);

				dGV_horarios.Rows.Add(desde, hasta);
				iHorarios.Add(new RangoHorario(desde, hasta));
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{

			if (ckb_luenes.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "lunes-";
			}
			else
				iDias = iDias.Replace("lunes-", "");
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "martes-";
			}
			else
				iDias = iDias.Replace("martes-", "");
		}

		private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_miercoles.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);

				iDias += "miercoles-";
			}
			else
				iDias = iDias.Replace("miercoles-", "");
		}

		private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_jueves.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "jueves-";
			}
			else
				iDias = iDias.Replace("jueves-", "");
		}

		private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_viernes.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "viernes-";
			}
			else
				iDias = iDias.Replace("viernes-", "");
		}

		private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_sabado.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "sabado-";
			}
			else
				iDias = iDias.Replace("sabado-", "");
		}

		private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_domingo.Checked)
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				iDias += "domingo-";
			}
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
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteTexto(_Fuente.FuenteId);
			}
			else
			{
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteRss(_Fuente.FuenteId);
			}
		}
	}
}