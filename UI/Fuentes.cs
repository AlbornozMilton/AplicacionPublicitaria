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
		private List<IFuente> iFuentes;
		private IFuente _Fuente;
		string iFuenteSeleccionada;

		public Fuentes()
		{
			InitializeComponent();
			iFuentes = new ControladorFuentes().ObtenerFuentes();
		}

		public Fuentes(string pDescripcion, List<IFuente> pFuentes)
		{
			InitializeComponent();
			iFuentes = pFuentes;
			iFuenteSeleccionada = pDescripcion;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			fechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			fechaHasta.Value = fechaDesde.Value.AddMonths(1);
			CargarFuentes(-1);
		}

		private void CargarFuentes(int pIndex)
		{
			iFuentes = new ControladorFuentes().ObtenerFuentes();

			if (iFuentes.Count > 0)
			{
				cbx_Fuente.Items.Clear();

				for (int i = 0; i < iFuentes.Count; i++)
				{
					cbx_Fuente.Items.Add(iFuentes[i].Descripcion);
				}
				if (pIndex > 0)
					cbx_Fuente.SelectedIndex = pIndex;
				else if (pIndex == 0)
					cbx_Fuente.SelectedIndex = iFuentes.Count - 1;
				else
					cbx_Fuente.SelectedIndex = 0;
			}
		}

		private void CargarItems()
		{
			_Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			tbxTipoFuente.Text = _Fuente.GetType().Name;

			if (tbxTipoFuente.Text != "FuenteRSS")
			{
				btnAgregarItem.Visible = true;
				btnModificarItem.Visible = true;
				btnEliminarItem.Visible = true;
				fechaDesde.Enabled = true;
				fechaHasta.Enabled = true;
				iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteTexto(_Fuente.FuenteId, fechaDesde.Value, fechaHasta.Value);
			}
			else
			{
				btnAgregarItem.Visible = false;
				btnModificarItem.Visible = false;
				btnEliminarItem.Visible = false;

				IRssReader mRssReader = new RawXmlRssReader();
				var items = mRssReader.Read(((FuenteRSS)_Fuente).URL).ToList();
				if (items.Count > 0)
				{
					new VentanaEmergente("Solicitud exitosa", VentanaEmergente.TipoMensaje.Exito).Show();
					iItemBindingSource.DataSource = items.ToList();
					new ControladorFuentes().ActualizarItemsRss(items, _Fuente.FuenteId);
					fechaDesde.Enabled = false;
					fechaHasta.Enabled = false;
				}
				else
				{
					fechaDesde.Enabled = true;
					fechaHasta.Enabled = true;
					new VentanaEmergente("No se obtuvieron items en la solicitud reciente", VentanaEmergente.TipoMensaje.Alerta).Show();
					iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteRss(_Fuente.FuenteId, fechaDesde.Value.Date, fechaHasta.Value.Date);
				}
			}
			iItemBindingSource.ResetBindings(false);
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			AddModFuente f = new AddModFuente();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarFuentes(0);
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				AddModFuente f = new AddModFuente(_Fuente);
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarFuentes(cbx_Fuente.SelectedIndex);
			}
		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				try
				{
					if (_Fuente.Descripcion == "FuenteDefault")
						throw new Exception("La Fuente seleccionada no puede ser eliminada");

					new ControladorFuentes().ABMFuente(
						ControladorFuentes.Operacion.Eliminar,
						tbxTipoFuente.Text,
						_Fuente.FuenteId,
						_Fuente.Descripcion,
					    "");
					new VentanaEmergente("Fuente Eliminada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();

					CargarFuentes(-1);
				}
				catch (Exception E)
				{
					new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
				}
			}
		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			ItemsFuentes f = new ItemsFuentes(new ItemGenerico() { ItemId = 0, Fecha = DateTime.Now }, _Fuente.FuenteId);
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarItems(); 
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			if ((IItem)iItemBindingSource.Current != null)
			{
				ItemsFuentes f = new ItemsFuentes((IItem)iItemBindingSource.Current, _Fuente.FuenteId);
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarItems();
			}
		}

		private void btn_eliminarItem_Click(object sender, EventArgs e)
		{
			//cartel si desea elimiar
			try
			{
				if (iItemBindingSource.Current != null)
				{
					new ControladorFuentes().ABMItems(
								ControladorFuentes.Operacion.Eliminar,
								_Fuente.FuenteId,
								(IItem)iItemBindingSource.Current);
					new VentanaEmergente("Item Eliminado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					CargarItems();
				}
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lblX_Click(object sender, EventArgs e)
		{
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
			CargarItems();
		}
	}
}
