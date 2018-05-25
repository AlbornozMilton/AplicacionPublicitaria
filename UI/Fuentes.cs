using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;

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
			iFuentes = new ControladorBanner().ObtenerFuentes();
		}

		public Fuentes(string pNombreFuente, List<IFuente> pFuentes )
		{
			InitializeComponent();
			iFuentes = pFuentes;
			iFuenteSeleccionada = pNombreFuente;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			fechaDesde.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
			fechaHasta.Value = fechaDesde.Value.AddMonths(1);
			CargarFuentes();
		}

		private void CargarFuentes()
		{
			iFuentes = new ControladorBanner().ObtenerFuentes();

			if (iFuentes.Count > 0)
			{
				cbx_Fuente.Items.Clear();
				int index = 0;
				for (int i = 0; i < iFuentes.Count; i++)
				{
					cbx_Fuente.Items.Add(iFuentes[i].NombreFuente);
					if (cbx_Fuente.Items[i].ToString() == iFuenteSeleccionada)
						index = i;
				}
				cbx_Fuente.SelectedIndex = index;
			}
		}

		private void CargarItems()
		{
			_Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			tbxTipoFuente.Text = _Fuente.GetType().Name;

			if (tbxTipoFuente.Text != "FuenteRSS")
			{
				btnAgregarItem.Visible = true;
				btnModificarFuente.Visible = true;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteTexto(_Fuente.FuenteId, fechaDesde.Value, fechaHasta.Value);
			}
			else
			{
				btnAgregarItem.Visible = false;
				btnModificarFuente.Visible = false;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteRss(_Fuente.FuenteId, fechaDesde.Value, fechaHasta.Value);
			}
			iItemBindingSource.ResetBindings(false);
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			new AddModFuente().ShowDialog();
			CargarFuentes();
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				new AddModFuente(_Fuente).ShowDialog();
				CargarFuentes();
			}
		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				try
				{
					new ControladorBanner().ABMFuente(
						ControladorBanner.Operacion.Eliminar,
						tbxTipoFuente.Text,
						_Fuente.FuenteId,
						_Fuente.NombreFuente);
					new VentanaEmergente("Fuente Eliminada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					CargarFuentes();

				}
				catch (Exception E)
				{
					new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
				}
			}
		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			new ItemsFuentes(new ItemGenerico() { ItemId = 0, Fecha = DateTime.Now }, _Fuente.FuenteId).ShowDialog();
			CargarItems();
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			if ((IItem)iItemBindingSource.Current != null)
			{
				new ItemsFuentes((IItem)iItemBindingSource.Current, _Fuente.FuenteId).ShowDialog();
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
					new ControladorBanner().ABMItems(
								ControladorBanner.Operacion.Eliminar,
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

		private void btnTodosItems_Click(object sender, EventArgs e)
		{

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
