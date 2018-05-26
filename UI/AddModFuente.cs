using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class AddModFuente : Form
	{
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
				cbxTipoFuente.Items.Add(iFuente.GetType().Name);
				cbxTipoFuente.SelectedIndex = 0;
				tbxNombreFuente.Text = iFuente.NombreFuente;
				if (cbxTipoFuente.SelectedItem.ToString() == "FuenteRss")
					lblFuente.Text = "URL de Fuente";
			}
			else
			{
				string[] fuentes = { "FuenteRss", "TextoFijo" };
				cbxTipoFuente.Items.AddRange(fuentes);
			}

			tbxNombreFuente_Leave(this, e);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (tbxNombreFuente.Text != "" && cbxTipoFuente.SelectedItem != null)
			{
				Cursor = Cursors.WaitCursor;
				var controlador = new ControladorFuentes();
				if (iFuente != null) 
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Modificar, cbxTipoFuente.SelectedItem.ToString(), iFuente.FuenteId, tbxNombreFuente.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Modificada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				else
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Agregar, cbxTipoFuente.SelectedItem.ToString(), 0, tbxNombreFuente.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Agregada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				Close();
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
			if (cbxTipoFuente.SelectedItem.ToString() == "FuenteRss")
				lblFuente.Text = "URL de Fuente";
			else
				lblFuente.Text = "Nombre Fuente";

			tbxNombreFuente_Leave(sender, e);
		}

		private void tbxNombreFuente_Leave(object sender, EventArgs e)
		{
			try
			{
				if (cbxTipoFuente.SelectedItem != null && cbxTipoFuente.SelectedItem.ToString() == "FuenteRss")
				{
					if (String.IsNullOrWhiteSpace(this.tbxNombreFuente.Text))
					{
						//cLogger.Info("No se ingresó URL");
						btnAceptar.Enabled = false;
						throw new Exception("Debe ingresar una URL");
					}

					Uri mUrl;

					if (!Uri.TryCreate(this.tbxNombreFuente.Text.Trim(), UriKind.Absolute, out mUrl))
					{
						//cLogger.Info("URL inválida");
						btnAceptar.Enabled = false;
						throw new Exception("La URL absoluta ingresada no es válida.");
					}
					btnAceptar.Enabled = true;
				}
				else
					btnAceptar.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}
	}
}
