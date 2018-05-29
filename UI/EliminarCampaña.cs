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
        private Campania iCampaniaParaEliminar;

        private ControladorCampania iControladorCampania = new ControladorCampania();

        public EliminarCampaña(Campania pCampania)
        {
            InitializeComponent();
            this.iCampaniaParaEliminar = pCampania;

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
            iControladorCampania.EliminarCampania(this.iCampaniaParaEliminar);
            new VentanaEmergente("Campaña Eliminada Correctamente", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
            Close();
        }
        private void Cargar_dGV()
        {
            foreach (var imagen in iCampaniaParaEliminar.Imagenes)
            {
                dGV_Imagenes.Rows.Add(imagen.Nombre);
            }
        }
        private void CargarCampos()
        {
            Cargar_dGV();
        }

        private void EliminarCampaña_Load(object sender, EventArgs e)
        {
            CargarCampos();
            
        }
    }
}
