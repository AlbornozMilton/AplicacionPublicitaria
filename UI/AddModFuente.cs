﻿using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class AddModFuente : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private IFuente iFuente;

		public AddModFuente()
		{
			Loger.Info("Nueva Fuente");
			InitializeComponent();
		}

		public AddModFuente(IFuente pFuente)
		{
			Loger.Info("Modificar Fuente");
			InitializeComponent();
			iFuente = pFuente;
		}

		private void AddModFuente_Load(object sender, EventArgs e)
		{
			if (iFuente != null)
			{
				var nombreF = iFuente.GetType().Name;
				Loger.Info("Tipo Fuente :" + nombreF);
				cbxTipoFuente.Items.Add(nombreF);
				cbxTipoFuente.SelectedIndex = 0;
				tbxDescripcion.Text = iFuente.Descripcion;
				if (nombreF == "FuenteRSS")
				{
					lblUrl.Visible = true;
					txbUrl.Text = ((FuenteRSS)iFuente).URL;
					txbUrl.Visible = true;
					//http://feeds.bbci.co.uk/mundo/rss.xml
				}
			}
			else
			{
				string[] fuentes = { "FuenteRSS", "TextoFijo" };
				cbxTipoFuente.Items.AddRange(fuentes);
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbxTipoFuente.SelectedItem == null || tbxDescripcion.Text == "")
					throw new Exception("Debe rellenar todos los campos");

				if (txbUrl.Visible && txbUrl.Text == "")
					throw new Exception("Debe rellenar todos los campos");

				Cursor = Cursors.WaitCursor;
				var controlador = new ControladorFuentes();
				if (iFuente != null)
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Modificar, cbxTipoFuente.SelectedItem.ToString(), iFuente.FuenteId, tbxDescripcion.Text, txbUrl.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Modificada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					Loger.Info("Fuente Modificada");
				}
				else
				{
					controlador.ABMFuente(ControladorFuentes.Operacion.Agregar, cbxTipoFuente.SelectedItem.ToString(), 0, tbxDescripcion.Text, txbUrl.Text);
					Cursor = Cursors.Default;
					new VentanaEmergente("Fuente Agregada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					Loger.Info("Fuente Agregada");
				}

				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception E)
			{
				Loger.Error(E.Message);
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Loger.Info("Cancelar");
			Close();
		}

		private void cbxTipoFuente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTipoFuente.SelectedItem.ToString() == "FuenteRSS")
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

			Loger.Debug("Fuente seleccionada: " + cbxTipoFuente.SelectedItem.ToString());
		}

		private void txbUrl_Leave(object sender, EventArgs e)
		{
			try
			{
				if (cbxTipoFuente.SelectedItem != null && cbxTipoFuente.SelectedItem.ToString() == "FuenteRSS")
				{
					if (String.IsNullOrWhiteSpace(this.txbUrl.Text))
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
				Loger.Error(E.Message);
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}
	}
}
