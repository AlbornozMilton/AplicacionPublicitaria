using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class VentanaEmergente : Form
    {
        string Mensaje;
        TipoMensaje Tipo;
        public VentanaEmergente(string pMensaje, TipoMensaje pTipoMensaje)
        {
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
						lblMensaje2.Text = "¿Desea Continuar?";
						lblMensaje2.Visible = true;
						btnCancelar.Visible = true;
						btn_Aceptar.Text = "Si";
						btn_Aceptar.Location = new Point(262, 178);
						Size = new Size(422, 240);
					}
					break;
				default:
                    break;
            }
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
			DialogResult = DialogResult.OK;
			Close();
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
