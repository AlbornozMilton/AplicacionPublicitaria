using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.RSS;

namespace UI
{
	public partial class Fuentes : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private List<IFuente> iFuentes;
		private IFuente _Fuente;
		string iFuenteSeleccionada;

		public Fuentes()
		{
			Loger.Info("Fuentes");
			InitializeComponent();
			iFuentes = new ControladorFuentes().ObtenerFuentes();
		}

		public Fuentes(string pDescripcion)
		{
			Loger.Info("Fuentes - " + pDescripcion);

			InitializeComponent();
			iFuenteSeleccionada = pDescripcion;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			fechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			fechaHasta.Value = fechaDesde.Value.AddMonths(1);
			CargarFuentes();
		}

		private void CargarFuentes()
		{
			Loger.Debug("Obteniendo Fuentes de BD");
			iFuentes = new ControladorFuentes().ObtenerFuentes();

			cbx_Fuente.Items.Clear();

			for (int i = 0; i < iFuentes.Count; i++)
			{
				cbx_Fuente.Items.Add(iFuentes[i].Descripcion);
			}

			iItemBindingSource.Clear();
		}

		private void CargarItems()
		{
			try
			{
				Loger.Debug("Cargar Items");

				_Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
				tbxTipoFuente.Text = _Fuente.GetType().Name;
				Loger.Info("Tipo Fuente elegida " + tbxTipoFuente.Text);

				if (tbxTipoFuente.Text != "FuenteRSS")
				{
                    btn_peticionRss.Visible = false;
                    txlabel_teicionRss.Visible = false;
                    btnAgregarItem.Visible = true;
					btnModificarItem.Visible = true;
					btnEliminarItem.Visible = true;
					fechaDesde.Enabled = true;
					fechaHasta.Enabled = true;
					iItemBindingSource.DataSource = _Fuente.Items;
				}
				else
				{
                    iItemBindingSource.Clear();
                    btn_peticionRss.Visible = true;
                    txlabel_teicionRss.Visible = true;
                    btnAgregarItem.Visible = false;
                    btnModificarItem.Visible = false;
                    btnEliminarItem.Visible = false;
                }
				iItemBindingSource.ResetBindings(true);
			}
			catch (Exception e)
			{
				new VentanaEmergente(e.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void RssSinItems()
		{
            string msg = "";
			_Fuente.Items.Clear();
			var itemsRss = new ControladorFuentes().ItemsFuenteRss(_Fuente.FuenteId, null, null);

			if (itemsRss.Count > 0)
			{
				Loger.Debug("Items anteriores en BD para la Fuente seleccionada");
				_Fuente.Items.AddRange(itemsRss.OrderByDescending(f => f.Fecha));
                msg = "Se asignaron los items locales de la última petición";

            }
			else // no tiene items rss anteriores en bd
			{
				Loger.Debug("No exiten items en BD para la Fuente seleccionada");
				Loger.Debug("Se asignaron items de la fuente por defecto");
                msg = "Se asignaron items de la fuente por defecto";
                _Fuente.Items.AddRange(new ControladorFuentes().ItemsFuenteTexto(1, null, null).OrderByDescending(f => f.Fecha));
			}

			iItemBindingSource.DataSource = _Fuente.Items;
            new VentanaEmergente(msg, VentanaEmergente.TipoMensaje.Informacion).ShowDialog();

        }

        private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			Loger.Info("Agregar Fuente");
			AddModFuente f = new AddModFuente();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarFuentes();
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				Loger.Info("Modificar Fuente");

				AddModFuente f = new AddModFuente(_Fuente);
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarFuentes();
			}
		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				try
				{
					Loger.Info("Eliminar Fuente");

					if (_Fuente.FuenteId == 1)
						throw new Exception("La Fuente seleccionada no puede ser eliminada");

					VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar la Fuente seleccionada?", VentanaEmergente.TipoMensaje.SiNo);
					ve.ShowDialog();
					if (ve.DialogResult == DialogResult.OK)
					{
						new ControladorFuentes().ABMFuente(
							ControladorFuentes.Operacion.Eliminar,
							tbxTipoFuente.Text,
							_Fuente.FuenteId,
							_Fuente.Descripcion,
							"");
						new VentanaEmergente("Fuente Eliminada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
						CargarFuentes();
					}
					ve.Dispose();
				}
				catch (Exception E)
				{
					new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
				}
			}
		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			Loger.Info("Agregar Item");
			ItemsFuentes f = new ItemsFuentes(new ItemGenerico() { ItemId = 0, Fecha = DateTime.Now }, _Fuente.FuenteId);
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarFuentes();
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			if ((IItem)iItemBindingSource.Current != null)
			{
				Loger.Info("Modificar Item");

				ItemsFuentes f = new ItemsFuentes((IItem)iItemBindingSource.Current, _Fuente.FuenteId);
				iItemBindingSource.SuspendBinding();
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarFuentes();
			}
		}

		private void btn_eliminarItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (iItemBindingSource.Current != null)
				{
					Loger.Info("Eliminar Item");

					if (_Fuente.FuenteId == 1 && _Fuente.Items.Count == 1)
						throw new Exception("El Item de la Fuente seleccionada no puede ser eliminado");

					VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar el Item seleccionado?", VentanaEmergente.TipoMensaje.SiNo);
					ve.ShowDialog();
					if (ve.DialogResult == DialogResult.OK)
					{
						new ControladorFuentes().ABMItems(
									ControladorFuentes.Operacion.Eliminar,
									_Fuente.FuenteId,
									(IItem)iItemBindingSource.Current);
						new VentanaEmergente("Item Eliminado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
						CargarFuentes();
					}
					ve.Dispose();
				}
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Loger.Info("Hecho");
			Close();
		}

		private void lblX_Click(object sender, EventArgs e)
		{
			Loger.Info("Salir");
			Close();
		}

		private void lbl__Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void cbx_Fuente_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarItems();
		}

		private void HoverLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true)[0].Visible = true;
		}

		private void LeaveLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true).First().Visible = false;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedIndex > -1)
			{
				Loger.Debug("Buscar items");
				btnBuscar.BorderStyle = BorderStyle.Fixed3D;
				Cursor = Cursors.WaitCursor;
				CargarItems();
				btnBuscar.BorderStyle = BorderStyle.None;
				Cursor = Cursors.Default;
			}
		}

		private void btnBuscar_MouseHover(object sender, EventArgs e)
		{
			btnBuscar.BorderStyle = BorderStyle.FixedSingle;
		}

		private void btnBuscar_MouseLeave(object sender, EventArgs e)
		{
			btnBuscar.BorderStyle = BorderStyle.None;
		}

        private void btn_peticionRss_Click(object sender, EventArgs e)
        {
            try
            {
                IRssReader mRssReader = new RawXmlRssReader();

                var iFuente = (FuenteRSS)_Fuente;
                Loger.Debug("Petición de Fuente RSS: " + iFuente.URL);

                var itemsRss = mRssReader.Read(iFuente.URL).ToList();

                if (itemsRss.Count > 0)
                {
                    fechaDesde.Enabled = false;
                    fechaHasta.Enabled = false;
                    iItemBindingSource.DataSource = itemsRss;
                    new ControladorFuentes().ActualizarItemsRss(itemsRss, _Fuente.FuenteId);
                    new VentanaEmergente("Solicitud RSS exitosa", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
                }
                else
                {
                    fechaDesde.Enabled = true;
                    fechaHasta.Enabled = true;
                    new VentanaEmergente("No se ha podido establecer conexión a RSS", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
                    RssSinItems();
                }
            }
            catch (Exception ex)
            {
                new VentanaEmergente(ex.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
                RssSinItems();
            }
        }
    }
}
