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
    public partial class PantallaOperativa : Form
    {
        private Campania iCampaniaActual;
        private Campania iCampaniaSiguiente;

        public PantallaOperativa()
        {
            InitializeComponent();
          //  this.PrimerCampania();
        }

       // private void PrimerCampania()
       // {
       //     this.iCampaniaActual = ControladorCampania.ObtenerCampaniaSiguiente();
       //     this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
       //     this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente();
        //}

       // private Image ImagenCampania (Campania pCampania)
       // {
       //     Imagen imagenActual = pCampania.ProximaImagen();
       //     this.timer_ImagenesCampania.Interval = pCampania.iTiempo * 1000;
       //     return imagenActual.Picture;
        //}

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {

        }
    }
}
