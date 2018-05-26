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
    public partial class EliminarCampaña : Form
    {
        private Campania iCampaniaEliminada;

        private ControladorCampania iControladorCampania = new ControladorCampania();

        public EliminarCampaña(Campania pCampania)
        {
            InitializeComponent();
            this.iCampaniaEliminada = pCampania;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iControladorCampania.EliminarCampania(this.iCampaniaEliminada);
            new VentanaEmergente("Campaña Eliminada Correctamente", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
            Close();
        }
    }
}
