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

		public Fuentes()
		{
			InitializeComponent();
			iFuentes = new ControladorBanner().ObtenerFuentes();
		}

		public Fuentes(string pNombreFuente, List<IFuente> pFuentes )
		{
			InitializeComponent();
			iFuentes = pFuentes;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			foreach (var item in iFuentes)
			{
				cbx_Fuente.Items.Add(item.NombreFuente);
			}
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			new AddModFuente().ShowDialog();
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				new AddModFuente(iFuentes.ElementAt(cbx_Fuente.SelectedIndex)).ShowDialog(); 
			}
		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				try
				{
					var fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);

					new ControladorBanner().ABMFuente(
						ControladorBanner.Operacion.Eliminar,
						tbxTipoFuente.Text,
						fuente.FuenteId,
						fuente.NombreFuente);
					new VentanaEmergente("Fuente Eliminada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				catch (Exception E)
				{
					new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
				}
			}
		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			new ItemsFuentes(new ItemGenerico() { ItemId = 0}).ShowDialog();
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			new ItemsFuentes((ItemGenerico)iItemBindingSource.Current).ShowDialog();
		}

		private void btn_eliminarItem_Click(object sender, EventArgs e)
		{

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
			var fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			tbxTipoFuente.Text = fuente.GetType().Name;
			iItemBindingSource.DataSource = fuente.Items;

			if (tbxTipoFuente.Text != "FuenteRSS")
			{
				btnAgregarItem.Visible = true;
				btnModificarItem.Visible = true;
			}
			else
			{
				btnAgregarItem.Visible = false;
				btnModificarItem.Visible = false;
			}
		}
	}
}
