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
		private static readonly log4net.ILog Looger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		List<RangoHorario> iHorarios = new List<RangoHorario>();
		ControladorExtra iControlExtra = new ControladorExtra();
		List<IFuente> iFuentes = new List<IFuente>();
		private Banner iBanner;
		string iDias = "";

		public AgregarBanner()
		{
			Looger.Debug("Nuevo banner");
			InitializeComponent();
		}

		public AgregarBanner(Banner pBanner)
		{
			Looger.Debug("Modificando banner");
			InitializeComponent();
			iBanner = pBanner;
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			dGV_horarios.AllowUserToOrderColumns = true;
			RellenarFuentes();
			horaHasta.Value = DateTime.Now.AddHours(1);
			fechaHasta.Value = DateTime.Now.AddMonths(1);

			if (iBanner != null)
			{
				fechaDesde.Value = iBanner.RangoFecha.FechaInicio;
				fechaHasta.Value = iBanner.RangoFecha.FechaFin;

				cbx_Fuente.SelectedIndex = iFuentes.IndexOf(iFuentes.Where(f => f.FuenteId == iBanner.Fuente.FuenteId).First());

				tbxNombreBanner.Text = iBanner.Nombre;

				string[] mDias = iBanner.RangoFecha.Dias.Split('-');
				foreach (string item in mDias)
				{
					if (item == "lunes")
						ckb_luenes.Checked = true;
					else if (item == "martes")
						ckb_martes.Checked = true;
					else if (item == "miercoles")
						ckb_miercoles.Checked = true;
					else if (item == "jueves")
						ckb_jueves.Checked = true;
					else if (item == "viernes")
						ckb_viernes.Checked = true;
					else if (item == "sabado")
						ckb_sabado.Checked = true;
					else
						ckb_domingo.Checked = true;
				}

				//iDias = iBanner.RangoFecha.Dias + "-";
				iHorarios = iBanner.RangoFecha.Horarios;
				foreach (var item in iHorarios)
				{
					dGV_horarios.Rows.Add(item.HoraInicio, item.HoraFin);
				}
			}

			pictureBox1_Click(null, null);
		}

		private void RellenarFuentes()
		{
			cbx_Fuente.Items.Clear();
			iFuentes = new ControladorFuentes().ObtenerFuentes();
			foreach (IFuente fuente in iFuentes)
			{
				cbx_Fuente.Items.Add(fuente.Descripcion);
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
				string[] horaInicio = dGV_horarios.CurrentRow.Cells[0].Value.ToString().Split(':');
				TimeSpan horaInicioTime = new TimeSpan(Convert.ToInt32(horaInicio[0]), Convert.ToInt32(horaInicio[1]), 0);
				iHorarios.Remove(iHorarios.Where(h => h.HoraInicio == horaInicioTime).SingleOrDefault());
				dGV_horarios.Rows.Remove(dGV_horarios.CurrentRow);
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (tbxNombreBanner.Text == "")
					throw new Exception("Debe rellenar el campo Nombre");

				if (iDias == "" || iDias == null)
					throw new Exception("Debe elegir al menos un Día");

				if (dGV_horarios.Rows.Count == 0)
					throw new Exception("Debe elegir al menos un Horario");

				if (txbTipoFuente.Text == "")
					throw new Exception("Debe elegir una Fuente");

				VentanaEmergente f = null;
				if (dGV_itemsFuente.Rows.Count == 0)
				{
					f = new VentanaEmergente("Para este banner se mostraran items por defecto \n \n ¿Desea continuar?", VentanaEmergente.TipoMensaje.SiNo);
					f.ShowDialog();
				}

				if (dGV_itemsFuente.Rows.Count > 0 || f.DialogResult == DialogResult.OK)
				{
					iDias = "";
					if (ckb_luenes.Checked)
						iDias += "lunes-";
					if (ckb_martes.Checked)
						iDias += "martes-";
					if (ckb_miercoles.Checked)
						iDias += "miercoles-";
					if (ckb_jueves.Checked)
						iDias += "jueves-";
					if (ckb_viernes.Checked)
						iDias += "viernes-";
					if (ckb_sabado.Checked)
						iDias += "sabado-";
					if (ckb_domingo.Checked)
						iDias += "domingo-";
					iDias = iDias.Remove(iDias.Length-1);

					if (iBanner != null)
					{
						new ControladorBanner().ModificarBanner(iBanner.BannerId, tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios.OrderBy(h => h.HoraInicio).ToList(), iDias);
						new VentanaEmergente("Banner Modificado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					}
					else
					{
						new ControladorBanner().AgregarBanner(tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios.OrderBy(h => h.HoraInicio).ToList(), iDias);
						new VentanaEmergente("Banner Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					}
					Close();
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

		private void ControlFecha(int pBannerExcluido)
		{
			try
			{
				if (iBanner == null)
				{
					dGV_horarios.Rows.Clear();
					iHorarios.Clear();
				}
				iControlExtra.ActualizarBannersEnRangoFecha(pBannerExcluido, fechaDesde.Value, fechaHasta.Value);
				if (iBanner != null)
					iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
			}
			catch (ApplicationException)
			{
				if (iBanner != null)
				{
					fechaDesde.Value = iBanner.RangoFecha.FechaInicio;
					fechaHasta.Value = iBanner.RangoFecha.FechaFin;
				}
				new VentanaEmergente("Para las fechas elegidas no se permiten los dias y/o horarios", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
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
				dGV_horarios.Rows.Add(desde.ToString("hh\\:mm"), hasta.ToString("hh\\:mm"));
			}
			catch (ApplicationException E)
			{
				iHorarios.RemoveAt(iHorarios.Count - 1);
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ControlCheckedDia(string pDia, object sender)
		{
			try
			{
				iControlExtra.ComprobarHorarioBanner(iHorarios, iDias += pDia);
			}
			catch (ApplicationException E)
			{
				iDias = iDias.Replace(pDia, "");
				((CheckBox)sender).Checked = false;
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}
		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_luenes.Checked)
				ControlCheckedDia("lunes-", sender);
			else
				iDias = iDias.Replace("lunes-", "");
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
				ControlCheckedDia("martes-", sender);
			else
				iDias = iDias.Replace("martes-", "");
		}

		private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_miercoles.Checked)
				ControlCheckedDia("miercoles-", sender);
			else
				iDias = iDias.Replace("miercoles-", "");
		}

		private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_jueves.Checked)
				ControlCheckedDia("jueves-", sender);
			else
				iDias = iDias.Replace("jueves-", "");
		}

		private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_viernes.Checked)
				ControlCheckedDia("viernes-", sender);
			else
				iDias = iDias.Replace("viernes-", "");
		}

		private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_sabado.Checked)
				ControlCheckedDia("sabado-", sender);
			else
				iDias = iDias.Replace("sabado-", "");
		}

		private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_domingo.Checked)
				ControlCheckedDia("domingo-", sender);
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
				iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteTexto(_Fuente.FuenteId, null, null);
			}
			else
			{
				IRssReader mRssReader = new RawXmlRssReader();
				var items = mRssReader.Read(((FuenteRSS)_Fuente).URL).ToList();
				if (items.Count > 0)
				{
					new VentanaEmergente("Solicitud web exitosa", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					iItemBindingSource.DataSource = items.ToList();
					new ControladorFuentes().ActualizarItemsRss(items, _Fuente.FuenteId);
				}
				else
				{
					new VentanaEmergente("No se obtuvieron items en la solicitud web reciente", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
					//iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteRss(_Fuente.FuenteId, fechaDesde.Value.Date, fechaHasta.Value.Date);
					iItemBindingSource.DataSource = _Fuente.Items;
				}
			}
			iItemBindingSource.ResetBindings(false);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (iBanner != null)
				ControlFecha(iBanner.BannerId);
			else
				ControlFecha(0);
		}
	}
}