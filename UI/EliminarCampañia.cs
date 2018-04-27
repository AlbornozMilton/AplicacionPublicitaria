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
    public partial class EliminarCampañia : Form
    {
        private ControladorCampania iControladorCampania = new ControladorCampania();
        private List<Campania> iListaCampanias = new List<Campania>();

        public EliminarCampañia()
        {
            InitializeComponent();
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

        private void EliminarCampañia_Load(object sender, EventArgs e)
        {
            iListaCampanias = iControladorCampania.ObtenerTodasCampanias();
            dataGridView1.AutoGenerateColumns= false;
            dataGridView1.DataSource = iListaCampanias;
        
        }
    }
}
