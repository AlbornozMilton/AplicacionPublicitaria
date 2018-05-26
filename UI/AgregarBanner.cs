using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.RSS;

namespace UI
{
	public partial class AgregarBanner : Form
	{
		List<RangoHorario> iHorarios = new List<RangoHorario>();
		ControladorExtra iControlExtra = new ControladorExtra();
		List<IFuente> iFuentes = new List<IFuente>();
		string iDias;

		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			RellenarFuentes();
			iDias = "";
			fechaHasta.Value = DateTime.Now.AddMonths(1);
			horaHasta.Value = DateTime.Now.AddHours(1);
		}

		private void RellenarFuentes()
		{
			cbx_Fuente.Items.Clear();
			iFuentes = new ControladorFuentes().ObtenerFuentes();
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
				iHorarios.RemoveAt(dGV_horarios.CurrentRow.Index);
				dGV_horarios.Rows.Remove(dGV_horarios.CurrentRow);
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
				//throw new Exception("Debe elegir una Fuente que contenga al menos un Item");
				{
					VentanaEmergente f = new VentanaEmergente("Para este bannar se mostraran items por defecto" , VentanaEmergente.TipoMensaje.SiNo);
					f.ShowDialog();
					if (f.DialogResult == DialogResult.OK)
					{
						// borra ultimo guion para que futuro Split('-') no genere un item string vacio
						iDias = iDias.Remove(iDias.Length - 1);

						new ControladorBanner().AgregarBanner(tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios, iDias);
						new VentanaEmergente("Banner Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
						Close();
					}
				}
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

				iHorarios.Add(new RangoHorario(desde, hasta));
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
				dGV_horarios.Rows.Add(desde, hasta);

			}
			catch(ApplicationException E)
			{
				iHorarios.RemoveAt(iHorarios.Count-1);
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ControlCheckedDia(string pDia, CheckBox sender)
		{
			try
			{
				iDias += pDia;
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
			}
			catch (ApplicationException E)
			{
				iDias = iDias.Replace(pDia, "");
				sender.Checked = false;
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}
		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{

			if (ckb_luenes.Checked)
				ControlCheckedDia("lunes-", (CheckBox)sender);
			else
				iDias = iDias.Replace("lunes-", "");
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
				ControlCheckedDia("martes-", (CheckBox)sender);
			else
				iDias = iDias.Replace("martes-", "");
		}

		private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_miercoles.Checked)
				ControlCheckedDia("miercoles-", (CheckBox)sender);
			else
				iDias = iDias.Replace("miercoles-", "");
		}

		private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_jueves.Checked)
				ControlCheckedDia("jueves-", (CheckBox)sender);
			else
				iDias = iDias.Replace("jueves-", "");
		}

		private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_viernes.Checked)
				ControlCheckedDia("viernes-",(CheckBox)sender);
			else
				iDias = iDias.Replace("viernes-", "");
		}

		private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_sabado.Checked)
				ControlCheckedDia("sabado-", (CheckBox)sender);
			else
				iDias = iDias.Replace("sabado-", "");
		}

		private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_domingo.Checked)
				ControlCheckedDia("domingo-", (CheckBox)sender);
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
			CargarItems();
		}
		private void CargarItems()
		{
			IFuente _Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			txbTipoFuente.Text = _Fuente.GetType().Name;

			if (txbTipoFuente.Text != "FuenteRSS")
			{
				iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteTexto(_Fuente.FuenteId, fechaDesde.Value, fechaHasta.Value);
			}
			else
			{
				IRssReader mRssReader = new RawXmlRssReader();
				var items = mRssReader.Read(_Fuente.NombreFuente).ToList();
				if (items.Count > 0)
				{
					new VentanaEmergente("Solicitud web exitosa", VentanaEmergente.TipoMensaje.Exito).Show();
					iItemBindingSource.DataSource = items.ToList();
					new ControladorFuentes().ActualizarItemsRss(items, _Fuente.FuenteId);
				}
				else
				{
					new VentanaEmergente("No se obtuvieron items en la solicitud web reciente", VentanaEmergente.TipoMensaje.Alerta).Show();
					iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteRss(_Fuente.FuenteId, fechaDesde.Value, fechaHasta.Value);
				}
			}
			iItemBindingSource.ResetBindings(false);
		}
	}
}