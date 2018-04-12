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

        List<Campania> campaniasHoy = new List<Campania>();

        public Menu()
        {
            InitializeComponent();
        }
        private void PresentarPubl_Click(object sender, EventArgs e)
        {
            new PantallaOperativa(campaniasHoy).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AgregarCampaña().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            campaniasHoy = new ControladorCampania().ObtenerCampaniasParaElDia(DateTime.Now);
        }
    }
}
