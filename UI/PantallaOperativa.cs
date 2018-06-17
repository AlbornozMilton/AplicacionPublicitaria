﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.RSS;

namespace UI
{
    public partial class PantallaOperativa : Form
    {
        private ControladorCampania iControladorCampania = new ControladorCampania();
		private ControladorBanner iControladorBanner = new ControladorBanner();
        private List<Campania> iCampaniasHoy = new List<Campania>();
        private Campania iCampaniaActual;
        private Campania iCampaniaSiguiente;

		private int posx;

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

			timer_Banner.Interval = 1000000; 
			timer_Banner.Enabled = true;
			timer_TextoDeslizable.Interval = 10;
			timer_TextoDeslizable.Enabled = true;

			//inicar tiempo banner
		}

        private void ObtenerPrimerCampania()
        {
            this.iCampaniaActual = iControladorCampania.ObtenerCampaniaActual(this.iCampaniasHoy);
            this.MostrarCampania();
        }

        private void MostrarCampania()
        {
            //this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
            //this.pictureBox_ImagenCamp.Image = this.ObtenerImagenCampania(this.iCampaniaActual);
            this.backgroundWorker_CambioCamp.RunWorkerAsync();
        }

        private Image ObtenerImagenCampania(Campania pCampania)
        {
            Imagen imagenActual = pCampania.SiguienteImagen();
            this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
            return Image.FromFile(imagenActual.Ruta);
        }

        private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
        {
             //this.pictureBox_ImagenCamp.Image = this.ObtenerImagenCampania(this.iCampaniaActual);
        }

        private void timer_IntervaloCamp_Tick(object sender, EventArgs e)
        {
            this.iCampaniaActual = this.iCampaniaSiguiente;
            this.MostrarCampania();
        }

        private void backgroundWorker_CambioCamp_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iCampaniaSiguiente = iControladorCampania.ObtenerCampaniaSiguiente(iCampaniasHoy, iCampaniaActual.RangoFecha.Horarios[0].HoraFin);
        }

        private void PantallaOperativa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

		private void PantallaOperativa_Load(object sender, EventArgs e)
		{
			iCampaniasHoy = iControladorCampania.ObtenerCampaniasParaElDia(DateTime.Today.Date);
			iControladorBanner.GenerarBannerFecha(DateTime.Now);

			//////---------------De prueba----------------
			TextoBanner.Location = new Point(panel_Banner.Location.X + panel_Banner.Width+1,TextoBanner.Location.Y);
			posx = TextoBanner.Location.X;
			//TextoBanner.Text = iControladorBanner.TextoDeFuenteActual();

			IRssReader mRssReader = new RawXmlRssReader();
			var items = mRssReader.Read("http://feeds.bbci.co.uk/mundo/rss.xml").ToList();

			foreach (var itemReader in items)
			{
				TextoBanner.Text += itemReader.Texto + "//";
			}
			TextoBanner.Text = items[0].Fecha + " (" + (items[0].Url) + ") " + items[0].Titulo + ": " + items[0].Texto;

			TextoBanner.Width = TextoBanner.Text.Length * Convert.ToInt32(TextoBanner.Font.Size);
			//posx = TextoBanner.Location.Y;
			//////---------------De prueba----------------

			//configurarTimersbanner(tiempo en pantalla, tiempo velocidad de texto)
			this.ConfigurarTimers();
            this.ObtenerPrimerCampania();
        }

		private void timer_TextoDeslizable_Tick(object sender, EventArgs e)
		{
			//TODO: posx configurable segun cantidad de texto y tiempo
			posx -= 3;
			if ((TextoBanner.Location.X + TextoBanner.Width) <= panel_Banner.Location.X)
			{
				TextoBanner.Location = new Point(
				panel_Banner.Location.X + panel_Banner.Width,
				TextoBanner.Location.Y);
				posx = TextoBanner.Location.X;
			}
			TextoBanner.Location = new Point(posx, TextoBanner.Location.Y);
		}
	}
}