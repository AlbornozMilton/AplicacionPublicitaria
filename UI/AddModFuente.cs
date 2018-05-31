﻿using System;
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
				var nombreF = iFuente.GetType().Name;
				cbxTipoFuente.Items.Add(nombreF);
				cbxTipoFuente.SelectedIndex = 0;
				tbxNombreFuente.Text = iFuente.NombreFuente;
				if (nombreF == "FuenteRss")
				{
					txbUrl.Text = ((FuenteRSS)iFuente).URL;
					//http://feeds.bbci.co.uk/mundo/rss.xml
					//txbUrl.Visible = true;
				}
			}
			else
			{
				string[] fuentes = { "FuenteRss", "TextoFijo" };
				cbxTipoFuente.Items.AddRange(fuentes);
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (tbxNombreFuente.Text != "" && cbxTipoFuente.SelectedItem != null)
			{
				Cursor = Cursors.WaitCursor;
				var controlador = new ControladorFuentes();
				if (iFuente != null)
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Modificar, cbxTipoFuente.SelectedItem.ToString(), iFuente.FuenteId, tbxNombreFuente.Text, txbUrl.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Modificada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				else
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Agregar, cbxTipoFuente.SelectedItem.ToString(), 0, tbxNombreFuente.Text, txbUrl.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Agregada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				DialogResult = DialogResult.OK;
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
			{
				lblUrl.Visible = true;
				txbUrl.Visible = true;
				txbUrl_Leave(null, null);
			}
			else
			{
				lblUrl.Text = "";
				txbUrl.Visible = false;
				lblUrl.Visible = false;
				btnAceptar.Enabled = true;
			}
		}

		private void txbUrl_Leave(object sender, EventArgs e)
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

					if (!Uri.TryCreate(this.txbUrl.Text.Trim(), UriKind.Absolute, out mUrl))
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
