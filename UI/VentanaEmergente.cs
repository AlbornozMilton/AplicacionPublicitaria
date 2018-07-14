using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	public partial class VentanaEmergente : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		string Mensaje;
		TipoMensaje Tipo;
		public VentanaEmergente(string pMensaje, TipoMensaje pTipoMensaje)
		{
			Loger.Info("Ventana Emergente - " + "Mensaje: " + pMensaje + "-" + "Tipo: " + pTipoMensaje.ToString());
			InitializeComponent();
			Mensaje = pMensaje;
			Tipo = pTipoMensaje;
		}

		private void VentanaEmergente_Load(object sender, EventArgs e)
		{
			lbl_Mensaje.Text = Mensaje;
			pbox_Icono.SizeMode = PictureBoxSizeMode.StretchImage;
			switch (Tipo)
			{
				case TipoMensaje.Exito:
					{
						lbl_Titulo.Text = "¡Exito!";
						pbox_Icono.Image = Properties.Resources.Exito;
					}
					break;
				case TipoMensaje.Alerta:
					{
						lbl_Titulo.Text = "¡Alerta!";
						pbox_Icono.Image = Properties.Resources.Advertencia;
					}
					break;
				case TipoMensaje.Informacion:
					{
						lbl_Titulo.Text = "Información";
						pbox_Icono.Image = Properties.Resources.Informacion;
					}
					break;
				case TipoMensaje.SiNo:
					{
						lbl_Titulo.Text = "Atención";
						pbox_Icono.Image = Properties.Resources.Informacion;
						btnCancelar.Visible = true;
						btn_Aceptar.Text = "Si";
						btn_Aceptar.Location = new Point(287, 142);
						//Size = new Size(393, 218);
					}
					break;
				default:
					break;
			}

			Focus();
		}

		public enum TipoMensaje
		{
			Exito,
			Alerta,
			Informacion,
			SiNo
		}

		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			Loger.Info("Aceptar");
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Loger.Info("Cancelar");
			DialogResult = DialogResult.Cancel;
		}
	}
}
