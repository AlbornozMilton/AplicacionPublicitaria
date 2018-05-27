using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AgregarCampania_Click(object sender, EventArgs e)
        {
            new AgregarCampaña().ShowDialog();
        }

        private void btn_Reproducir_Click(object sender, EventArgs e)
        {
            new PantallaOperativa().ShowDialog();
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			new AgregarBanner().ShowDialog();
		}

		private void btnEditarBanner_Click(object sender, EventArgs e)
		{
			BuscarBanner f = new BuscarBanner();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
			{
				new AgregarBanner(f.BanSelected).ShowDialog();
			}
			f.Dispose();
		}

		private void btnEliminarBanner_Click(object sender, EventArgs e)
		{
			BuscarBanner f = new BuscarBanner();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
			{
				VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar el Banner seleccionado?", VentanaEmergente.TipoMensaje.SiNo);
				ve.ShowDialog();
				if (ve.DialogResult == DialogResult.OK)
				{
					new ControladorBanner().EliminarBanner(f.BanSelected.BannerId);
					new VentanaEmergente("Banner Eliminado", VentanaEmergente.TipoMensaje.Exito);
				}
				ve.Dispose();
			}
			f.Dispose();
		}

		private void btnFuentes_Click(object sender, EventArgs e)
		{
			new Fuentes().ShowDialog();
		}

        private void btn_EliminarCampania_Click(object sender, EventArgs e)
        {    
            BuscarCampaña iVentanaBuscar = new BuscarCampaña();
            iVentanaBuscar.ShowDialog();
            new EliminarCampaña(iVentanaBuscar.iCampaniaSeleccionada).ShowDialog();
        }
    }
}
