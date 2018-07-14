using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class PantallaOperativa : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private ControladorCampania iControladorCampania = new ControladorCampania();
		private ControladorBanner iControladorBanner = new ControladorBanner();
		private List<Campania> iCampaniasHoy = new List<Campania>();
		private Campania iCampaniaActual;
		private Campania iCampaniaSiguiente;

		private int posx, item = 0;

		public PantallaOperativa()
		{
			Loger.Debug("Ejecutando pantalla operativa");
			InitializeComponent();
		}

		private void ConfigurarTimers()
		{
			Loger.Debug("Configurando timers");

			this.timer_IntervaloImagen.Interval = 1000;
			this.timer_IntervaloImagen.Enabled = true;
			this.timer_IntervaloCamp.Interval = 1000;
			this.timer_IntervaloCamp.Enabled = true;
		}

		private void ObtenerPrimerCampania()
		{
			Loger.Debug("Obteniendo primer Campaña");

			this.iCampaniaActual = iControladorCampania.ObtenerCampaniaActual(this.iCampaniasHoy);
			this.MostrarCampania();
		}

		private void MostrarCampania()
		{
			Loger.Debug("Seteando intervalo de Campaña");
			this.timer_IntervaloCamp.Interval = Convert.ToInt32(Math.Truncate(iCampaniaActual.RangoFecha.Horarios[0].HoraFin.TotalMilliseconds - DateTime.Now.TimeOfDay.TotalMilliseconds));
			this.pictureBox_ImagenCamp.Image = this.ObtenerImagenCampania();
			this.backgroundWorker_CambioCamp.RunWorkerAsync();
		}

		private Image ObtenerImagenCampania()
		{
			Loger.Debug("Obtener Imagen de Campania");
			Loger.Info("Nombre de Campania: " + iCampaniaActual.Nombre);

			if (iCampaniaActual.Nombre == "Default")
			{
				this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
				return UI.Properties.Resources.ImagenPorDefecto;
			}
			else
			{
				Imagen imagenActual = iCampaniaActual.SiguienteImagen();
				this.timer_IntervaloImagen.Interval = iCampaniaActual.IntervaloTiempo * 1000;
				Loger.Info("Ruta Imagen: " + imagenActual.Ruta);
				return Image.FromFile(imagenActual.Ruta);
			}
		}

		private void timer_IntervaloImagen_Tick(object sender, EventArgs e)
		{
			this.pictureBox_ImagenCamp.Image = this.ObtenerImagenCampania();
		}

		private void timer_IntervaloCamp_Tick(object sender, EventArgs e)
		{
			Loger.Debug("timer_IntervaloCamp_Tick");
			this.iCampaniaActual = this.iCampaniaSiguiente;
			this.MostrarCampania();
		}

		private void backgroundWorker_CambioCamp_DoWork(object sender, DoWorkEventArgs e)
		{
			Loger.Debug("backgroundWorker_CambioCamp_DoWork");
			this.iCampaniaSiguiente = iControladorCampania.ObtenerCampaniaSiguiente(iCampaniasHoy, iCampaniaActual.RangoFecha.Horarios[0].HoraFin);
		}

		private void PantallaOperativa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
			{
				Loger.Debug("Pantalla operativa cerrada");
				Close();
			}
		}

		private void PantallaOperativa_Load(object sender, EventArgs e)
		{
			Loger.Debug("ObtenerCampaniasParaElDia");
			Loger.Debug("ObtenerCampaniasParaElDia");
			iCampaniasHoy = iControladorCampania.ObtenerCampaniasParaElDia(DateTime.Today.Date);
			//////---------------Banners----------------
			Loger.Debug("GenerarBannerFecha: "+ DateTime.Now);
			iControladorBanner.GenerarBannerFecha(DateTime.Now);
			Loger.Debug("ActBannerActual");
			iControladorBanner.ActBannerActual(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0));
			Loger.Info(TextoBanner);
			GenerarTextoBanner(TextoBanner);
			timer_Banner.Interval = iControladorBanner.IntervaloBanner();
			Loger.Info(timer_Banner.Interval);
			timer_TextoDeslizable.Interval = 2;
			timer_Banner.Enabled = true;
			timer_TextoDeslizable.Enabled = true;
			/////--------------------

			this.ConfigurarTimers();
			this.ObtenerPrimerCampania();

			pictureLoading.Visible = false;
		}

		private void timer_Banner_Tick(object sender, EventArgs e)
		{
			Loger.Debug("timer_Banner_Tick");
			Loger.Debug("IntercambiarBanners");
			iControladorBanner.IntercambiarBanners();
			timer_Banner.Interval = iControladorBanner.IntervaloBanner();
			Loger.Info(timer_Banner.Interval);
			TextoBanner.Text = iControladorBanner.TextoDeFuenteActual(ref item);
			Loger.Info(TextoBanner);
			Loger.Debug("GenerarTextoBanner");
			GenerarTextoBanner(TextoBanner);
		}

		private void timer_TextoDeslizable_Tick(object sender, EventArgs e)
		{
			if ((TextoBanner.Location.X + TextoBanner.Width) <= panel_Banner.Location.X)
			{
				item++;
				GenerarTextoBanner(TextoBanner);
			}

			posx -= 4;
			TextoBanner.Location = new Point(posx, TextoBanner.Location.Y);
		}

		private void GenerarTextoBanner(Label textoBanner)
		{
			TextoBanner.Text = iControladorBanner.TextoDeFuenteActual(ref item);
			TextoBanner.Width = TextoBanner.Text.Length * Convert.ToInt32(TextoBanner.Font.Size);
			TextoBanner.Location = new Point(panel_Banner.Location.X + panel_Banner.Width, TextoBanner.Location.Y);
			posx = TextoBanner.Location.X;
		}
	}
}