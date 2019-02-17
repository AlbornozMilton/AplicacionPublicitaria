using System;
using System.Windows.Forms;
using Dominio;
using System.Linq;

namespace UI
{
    public partial class Menu : Form
    {
		
		public Menu()
        {
            MyLogger4Net.Logger.Debug("Inicio de la App");
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Cierre de la App");
            Close();
        }

        private void btn_AgregarCampania_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Agregar Campaña");
            new AgregarCampaña().ShowDialog();
		}

		private void btn_Reproducir_Click(object sender, EventArgs e)
        {
            new PantallaOperativa().ShowDialog();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
            MyLogger4Net.Logger.Debug("Agregar Banner");
			new AgregarBanner().ShowDialog();
		}

		private void btnEditarBanner_Click(object sender, EventArgs e)
		{
            MyLogger4Net.Logger.Debug("Modificar Banner");
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
            MyLogger4Net.Logger.Debug("Eliminar Banner");
            BuscarBanner f = new BuscarBanner();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
			{
				VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar el Banner seleccionado?", VentanaEmergente.TipoMensaje.SiNo);
				ve.ShowDialog();
				if (ve.DialogResult == DialogResult.OK)
				{
					new ControladorBanner().EliminarBanner(f.BanSelected.BannerId);
					new VentanaEmergente("Banner Eliminado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
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
            MyLogger4Net.Logger.Debug("Eliminar Campaña");
            BuscarCampaña iVentanaBuscar = new BuscarCampaña();
            iVentanaBuscar.ShowDialog();
            if (iVentanaBuscar.iCampaniaSeleccionada != null)
            {
                new EliminarCampaña(iVentanaBuscar.iCampaniaSeleccionada).ShowDialog();
            }
        }

		private void HoverLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true)[0].Visible = true;
		}

		private void LeaveLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true).First().Visible = false;
		}

        private void btnEditarCampania_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Modificar Campaña");
            BuscarCampaña iVentanaBuscar = new BuscarCampaña();
            iVentanaBuscar.ShowDialog();
            if (iVentanaBuscar.iCampaniaSeleccionada != null)
            {
                new AgregarCampaña(iVentanaBuscar.iCampaniaSeleccionada).ShowDialog();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
