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
       // private Campania iCampaniaActual;
       // private Campania iCampaniaSiguiente;

       // public PantallaOperativa()
       // {
       //     InitializeComponent();
       //     this.ConfigurarTimers();
       //     this.ConfigurarCampanias();
       // }

       // private void ConfigurarTimers()
       // {
       //     this.timer_IntervaloImagen.Interval = 1000;
       //     this.timer_IntervaloImagen.Enabled = true;
 
       // }

       //private void ConfigurarCampanias()
       //{
       //     this.iCampaniaActual = ControladorCampania.ObtenerCampaniaSiguiente();
       //     this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
       //     this.timer_IntervaloImagen.Interval = iCampaniaActual.iIntervaloTiempo * 1000;
       //     this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente();
       //}

       //private Image ImagenCampania (Campania pCampania)
       //{
       //     Imagen imagenActual = pCampania.ProximaImagen();
       //     return Image.FromFile(imagenActual.iRuta);
       //}

       // private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
       // {
       //     this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
       //     this.timer_IntervaloImagen.Interval = iCampaniaActual.iIntervaloTiempo * 1000;
       // }

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {

        }
    }
}
