using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class Menu : Form
    {
		//ubicacion: ...\AppPublicitaria\UI\bin\Debug\CarteleriaDigital.log
		private static readonly log4net.ILog Looger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public Menu()
        {
			Looger.Debug("Inicio de la App");
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
			Looger.Debug("Agregar Campaña");
            new AgregarCampaña().ShowDialog();
		}

		private void btn_Reproducir_Click(object sender, EventArgs e)
        {
            new PantallaOperativa().ShowDialog();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Looger.Debug("Agregar Banner");
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
            if (iVentanaBuscar.iCampaniaSeleccionada != null)
            {
                new EliminarCampaña(iVentanaBuscar.iCampaniaSeleccionada).ShowDialog();
            }
        }
    }
}
