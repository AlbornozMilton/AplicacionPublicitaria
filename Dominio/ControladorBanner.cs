using System;
using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using AutoMapper;
using System.Threading;

namespace Dominio
{
	public class ControladorBanner
	{
		UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());

		private List<Banner> BannersDelDia = new List<Banner>();
		public Banner BannerActual { get; private set; }
		public Banner BannerProximo { get; private set; }

		private Thread hiloBanner;


		public void GenerarBannerFecha(DateTime pDia)
		{
			List<Banner> result = new List<Banner>();
			foreach (var item in iUOfW.RepositorioBanner.BannersEnFecha(pDia.Date))
			{
				result.Add(Mapper.Map<Persistencia.Dominio.Banner, Banner>(item));
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
					bannerResult = BannerDefault(auxHFin, pHora);
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
			BannerActual = GetBanner(pHora);

			hiloBanner = new Thread(() => ActBannerProximo());
			hiloBanner.Start();
		}

		public void ActBannerProximo()
		{
			foreach (var hora in BannerActual.RangoFecha.Horarios)
			{
				if (hora.HoraFin <= DateTime.Now.TimeOfDay && hora.HoraFin >= DateTime.Now.TimeOfDay)
				{
					BannerProximo = GetBanner(hora.HoraFin.Add(new TimeSpan(0, 1, 0)));
					break;
				}
			}
		}

		public void IntercambiarBanners()
		{
			BannerActual = BannerProximo;
			hiloBanner = new Thread(() => ActBannerProximo());
			hiloBanner.Start();
		}

		private Banner BannerDefault(TimeSpan pHoraInicio, TimeSpan pHoraFin)
		{
			RangoFecha rf = new RangoFecha(new RangoHorario(pHoraInicio, pHoraFin));
			return new Banner("Publicidad por defecto", new ControladorFuentes().ObtenerFuenteTextoFijo(null, "FuenteDefault"), rf);
		}

		public int IntervaloBanner()
		{
			int intervalo = 0;
			foreach (var hora in BannerActual.RangoFecha.Horarios)
			{
				if (hora.HoraInicio <= DateTime.Now.TimeOfDay && hora.HoraFin >= DateTime.Now.TimeOfDay)
				{
					intervalo = Convert.ToInt32((hora.HoraFin - hora.HoraInicio).TotalMilliseconds);
					break;
				}
			}
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
