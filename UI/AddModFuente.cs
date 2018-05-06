using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class AddModFuente : Form
	{
		private List<TipoFuente> iTiposFuente = new List<TipoFuente>() { TipoFuente.RSS, TipoFuente.TextoFijo }; 
		private IFuente iFuente;

		public AddModFuente()
		{
			InitializeComponent();
		}

		public AddModFuente(IFuente pFuente)
		{
			InitializeComponent();
			iFuente = pFuente;
		}

		private void AddModFuente_Load(object sender, EventArgs e)
		{
			if (iFuente != null)
			{
				cbxTipoFuente.SelectedText = iFuente.TipoFuente.ToString();
				if (iFuente.TipoFuente == TipoFuente.RSS)
					lblFuente.Text = "URL de Fuente";
			}
			else
			{
				foreach (TipoFuente tipoFuente in iTiposFuente)
				{
					cbxTipoFuente.Items.Add(tipoFuente);
				}
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (lblFuente.Text != "" && cbxTipoFuente.SelectedItem != null)
			{
				var controlador = new ControladorBanner();
				if (iFuente != null) 
				{
					controlador.ABMFuente(ControladorBanner.Operacion.Modificar, iFuente);
				}
				else
				{
					if (cbxTipoFuente.SelectedItem.ToString() == "RSS")
						iFuente = new FuenteRSS(tbxNombreFuente.Text);
					else if (cbxTipoFuente.SelectedItem.ToString() == "TextoFijo")
						iFuente = new TextoFijo(tbxNombreFuente.Text);

					controlador.ABMFuente(ControladorBanner.Operacion.Agregar, iFuente);
				} 
			}
			else
				new VentanaEmergente("Debe rellenar todos los campos", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbxTipoFuente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTipoFuente.SelectedItem.ToString() == "RSS")
				lblFuente.Text = "URL de Fuente";
			else
				lblFuente.Text = "Nombre Fuente";
		}

		private void tbxNombreFuente_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//if (no pasa control de URL para RSS) -> excepcion
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}
	}
}
