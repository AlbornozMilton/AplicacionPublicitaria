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

        private Campania iCampaniaActual;
        private Campania iCampaniaSiguiente;
        private int indiceimg = 0;

        public PantallaOperativa()
         {
            InitializeComponent();
            this.timer_IntervaloImagen.Interval = 1000;
            this.timer_IntervaloImagen.Enabled = true;
            this.timer_IntervaloCamp.Interval = 1000;
            this.timer_IntervaloCamp.Enabled = true;
            this.iCampaniaActual = new ControladorCampania().ObtenerCampaniaActual();
            this.timer_IntervaloImagen.Interval = (iCampaniaActual.IntervaloTiempo) * 1000;
            this.timer_IntervaloCamp.Interval = (iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalSeconds - DateTime.Now.TimeOfDay.TotalSeconds) * 1000;
            //  this.timer_IntervaloImagen.Enabled = true;
            //  this.timer_IntervaloImagen.Start();
            this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
            this.pictureBox_ImagenCamp.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
         {
             this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
             this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
         }

        private Image ImagenCampania (Campania pCampania)
        {
            if (indiceimg >= (pCampania.Imagenes.Count))
            {
                indiceimg = 0;
            }
            Imagen imagenActual = pCampania.Imagenes[indiceimg];
            indiceimg++;
            return Image.FromFile(imagenActual.Ruta);
            
        }

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {
       
        }

        private void timer_IntervaloCamp_Tick(object sender, EventArgs e)
        {

        }
    }
}
