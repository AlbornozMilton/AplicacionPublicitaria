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
        private ControladorCampania iControladorCampania = new ControladorCampania();
        private List<Campania> iCampaniasHoy = new List<Campania>();
        private Campania iCampaniaActual;
        private Campania iCampaniaSiguiente;

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
            this.backgroundWorker_CambioCamp.RunWorkerAsync();
        }

        private void ConfigurarCampania()
        {
            this.iCampaniaActual = iControladorCampania.ObtenerCampaniaActual(this.iCampaniasHoy); //ver si el controlador se puede crear antes
            this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
            this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
           // this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente(listahoy);  //nose si se ejecuta en algun momento
        }

        private Image ImagenCampania(Campania pCampania)
        {
            Imagen imagenActual = pCampania.SiguienteImagen();
            this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
            return Image.FromFile(imagenActual.Ruta);
        }

        private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
         {
             this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
         }

        private void timer_IntervaloCamp_Tick(object sender, EventArgs e)
        {
            this.iCampaniaActual = this.iCampaniaSiguiente;
            if (iCampaniaSiguiente == null)
            {
                this.timer_IntervaloCamp.Interval = 60000;
                this.pictureBox_ImagenCamp.Image = Properties.Resources.btn_Adelante;
            }
            else
            {
                this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
                this.pictureBox_ImagenCamp.Image = this.ImagenCampania(this.iCampaniaActual);
                ////    this.iCampaniaSiguiente = ControladorCampania.ObtenerCampaniaSiguiente(listahoy);
            }
            this.backgroundWorker_CambioCamp.RunWorkerAsync();
        }

        private void backgroundWorker_CambioCamp_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iCampaniaSiguiente = iControladorCampania.ObtenerCampaniaSiguiente(iCampaniasHoy, iCampaniaActual.RangoFecha.Horarios[0].HoraFin);
        }

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {
            iCampaniasHoy = iControladorCampania.ObtenerCampaniasParaElDia(DateTime.Today.Date);
            this.ConfigurarTimers();
            this.ConfigurarCampania();
        }

    }
}
//ver q me devuelva el rango horaario actual en los 2 metodos
//otro timer de un min en seg plano