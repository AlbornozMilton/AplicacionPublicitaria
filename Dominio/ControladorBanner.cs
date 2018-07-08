using System;
using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using AutoMapper;
using System.Threading;
using Dominio.RSS;
using System.Linq;

namespace Dominio
{
	public class ControladorBanner
	{
		UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());

		private List<Banner> BannersDelDia;
		public Banner BannerActual { get; private set; }
		public Banner BannerProximo { get; private set; }

		private Thread hiloBanner;


		public void GenerarBannerFecha(DateTime pDia)
		{
			List<Banner> result = new List<Banner>();
			foreach (var item in iUOfW.RepositorioBanner.BannersEnFecha(pDia.Date))
			{
				var bannerMapped = Mapper.Map<Persistencia.Dominio.Banner, Banner>(item);
				result.Add(bannerMapped);

			}
			this.BannersDelDia = result;
		}

		public Banner GetBanner(TimeSpan pHora)
		{
			Banner bannerResult = null;
			TimeSpan auxHInicio = new TimeSpan(23, 59, 59), auxHFin = new TimeSpan(0, 0, 0);

			foreach (var banner in BannersDelDia)
			{
				foreach (var horario in banner.RangoFecha.Horarios)
				{
					if (horario.HoraInicio <= pHora && horario.HoraFin >= pHora)
					{
						bannerResult = banner;
						break;
					}

					if (horario.HoraFin > auxHFin && horario.HoraFin < pHora)
						auxHFin = horario.HoraFin;

					if (horario.HoraInicio < auxHInicio && horario.HoraInicio > pHora)
						auxHInicio = horario.HoraInicio;
				}
			}

			if (bannerResult == null)
			{
				if (auxHFin == new TimeSpan(0, 0, 0))
					bannerResult = BannerDefault(pHora, auxHInicio);
				else
				if (auxHInicio == new TimeSpan(23, 59, 59))
					bannerResult = BannerDefault(pHora, auxHInicio);
				else
					bannerResult = BannerDefault(auxHFin, auxHInicio);
			}

			return bannerResult;
		}

		public void ActBannerActual(TimeSpan pHora)
		{
			try
			{
				BannerActual = GetBanner(pHora);
				RequestRss();
				CorrerHilo();
			}
			catch (InvalidCastException)
			{
				CorrerHilo();
				throw;
			}
		}

		private void CorrerHilo()
		{
			hiloBanner = new Thread(() => ActBannerProximo());
			hiloBanner.Priority = ThreadPriority.Highest;
			hiloBanner.Start();
		}

		public void ActBannerProximo()
		{
			foreach (var hora in BannerActual.RangoFecha.Horarios)
			{
				if (hora.HoraInicio <= DateTime.Now.TimeOfDay && hora.HoraFin >= DateTime.Now.TimeOfDay)
				{
					BannerProximo = GetBanner(hora.HoraFin.Add(new TimeSpan(0, 0, 1)));
					break;
				}
			}
		}

		public void IntercambiarBanners()
		{
			BannerActual = BannerProximo;
			RequestRss();
			CorrerHilo();
		}

		private void RequestRss()
		{
			string url = new ControladorFuentes().RssUrl(BannerActual.Fuente.FuenteId);

			if (url != "")
			{
				IRssReader mRssReader = new RawXmlRssReader();
				var items = mRssReader.Read(url).ToList();
				if (items.Count > 0) //hubo respuesta
				{
					BannerActual.Fuente.Items.Clear();
					foreach (var item in items)
					{
						BannerActual.Fuente.Items.Add(new RssItem
						{
							Fecha = item.Fecha,
							Titulo = item.Titulo,
							Texto = item.Texto,
							Url = item.Url
						});
					}

					new ControladorFuentes().ActualizarItemsRss(items, BannerActual.Fuente.FuenteId);
				}
			}

			if (BannerActual.Fuente.Items.Count == 0) //no hubo respuesta y/o no tiene items en bd
				BannerActual.Fuente.Items = new ControladorFuentes().ObtenerFuenteTextoFijo(1, "").Items;
		}

		private Banner BannerDefault(TimeSpan pHoraInicio, TimeSpan pHoraFin)
		{
			RangoFecha rf = new RangoFecha(new RangoHorario(pHoraInicio, pHoraFin));
			return new Banner("FuenteDefault", new ControladorFuentes().ObtenerFuenteTextoFijo(1, ""), rf);
		}

		public int IntervaloBanner()
		{
			int intervalo = 0;
			foreach (var hora in BannerActual.RangoFecha.Horarios)
			{
				TimeSpan diff = DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, 1));
				if (hora.HoraInicio <= diff && hora.HoraFin >= diff)
				{
					intervalo = Convert.ToInt32((hora.HoraFin - DateTime.Now.TimeOfDay).TotalMilliseconds);
					break;
				}
			}

			if (intervalo == 0)
				throw new Exception("ceroooo");

			return Math.Abs(intervalo);
		}

		public string TextoDeFuenteActual(ref int pItem)
		{
			if (pItem + 1 > BannerActual.Fuente.Items.Count)
				pItem = 0;

			var item = BannerActual.Fuente.Items[pItem];

			return ("[" + item.Fecha + "] " + BannerActual.Fuente.Descripcion + ": " + item.Titulo + " - " + item.Texto);
		}

		//////////////////--------------------ADMINISTRACION-----------------

		public void AgregarBanner(string pNombre, int pIdFuente, DateTime pRFDesde, DateTime pRFHasta, List<RangoHorario> pRHorarios, string pDias)
		{
			RangoFecha rf = new RangoFecha(pRFDesde.Date, pRFHasta.Date, pDias, pRHorarios);
			var rfMapped = Mapper.Map<RangoFecha, Persistencia.Dominio.RangoFecha>(rf);
			iUOfW.RepositorioBanner.AgregarBanner(pNombre, pIdFuente, rfMapped);
		}

		public List<Banner> BuscarBanner(string pNombre, DateTime pDesde, DateTime pHasta)
		{
			List<Banner> result = new List<Banner>();
			foreach (var item in iUOfW.RepositorioBanner.BuscarBanner(pNombre, pDesde.Date, pHasta.Date))
			{
				result.Add(Mapper.Map<Persistencia.Dominio.Banner, Banner>(item));
			}
			return result;
		}

		public void EliminarBanner(int IdBanner)
		{
			iUOfW.RepositorioBanner.EliminarBanner(IdBanner);
		}

		public void ModificarBanner(int pBannerMod, string pNombre, int pIdFuente, DateTime pRFDesde, DateTime pRFHasta, List<RangoHorario> pRHorarios, string pDias)
		{
			RangoFecha rf = new RangoFecha(pRFDesde.Date, pRFHasta.Date, pDias, pRHorarios);
			var rfMapped = Mapper.Map<RangoFecha, Persistencia.Dominio.RangoFecha>(rf);
			iUOfW.RepositorioBanner.ModificarBanner(pBannerMod, pNombre, pIdFuente, rfMapped);
		}
	}
}
