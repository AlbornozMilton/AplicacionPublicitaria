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
        private List<Campania> iCampaniasHoy = new List<Campania>();
        private Campania iCampaniaActual;
        //private Campania iCampaniaSiguiente;
        //private int indiceimg = 0;

        public PantallaOperativa()
        {
            InitializeComponent();
        }

        private void ConfigurarTimers()
        {
            this.timer_IntervaloImagen.Interval = 1000;
            this.timer_IntervaloImagen.Enabled = true;
            this.timer_IntervaloCamp.Interval = 1000;
            this.timer_IntervaloCamp.Enabled = true;
          //  this.backgroundWorker_CambioCamp.RunWorkerAsync();
        }

        private void ConfigurarCampania()
        {
            this.iCampaniaActual = new ControladorCampania().ObtenerCampaniaActual(this.iCampaniasHoy); //ver si el controlador se puede crear antes
            this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
            //  this.timer_IntervaloImagen.Enabled = true;
            //  this.timer_IntervaloImagen.Start();
            this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
           // this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente(listahoy);  //nose si se ejecuta en algun momento
        }

        private Image ImagenCampania(Campania pCampania)
        {
            Imagen imagenActual = pCampania.SiguienteImagen();
            this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
            return Image.FromFile(imagenActual.Ruta);

            //por si no anda el enumerador

            //if (indiceimg >= (pCampania.Imagenes.Count))
            //{
            //    indiceimg = 0;
            //}
            //Imagen imagenActual = pCampania.Imagenes[indiceimg];
            //indiceimg++;
            //this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
            //return Image.FromFile(imagenActual.Ruta);
        }

        private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
         {
             this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
         }

        private void timer_IntervaloCamp_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Fin Campania");

        //    this.iCampaniaActual = this.iCampaniaSiguiente;
        //    this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
        //    //  this.timer_IntervaloImagen.Enabled = true;
        //    //  this.timer_IntervaloImagen.Start();
        //    //this.backgroundWorker_CambioCamp.RunWorkerAsync();
        //    this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
        ////    this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente(listahoy);
        }

        //private void backgroundWorker_CambioCamp_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente(listahoy);
        //}

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {
            iCampaniasHoy = new ControladorCampania().ObtenerCampaniasParaElDia(DateTime.Now);
            this.ConfigurarTimers();
            this.ConfigurarCampania();
        }
    }
}
