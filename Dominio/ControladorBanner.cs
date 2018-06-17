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
			TimeSpan auxHInicio = new TimeSpan(23, 59, 0), auxHFin = new TimeSpan(23, 59, 59);

			foreach (var banner in BannersDelDia)
			{
				foreach (var horario in banner.RangoFecha.Horarios)
				{
					if (horario.HoraInicio <= pHora && horario.HoraFin >= pHora)
					{
						bannerResult = banner; // si le corresponde el horario
						break;
					}
					else if (horario.HoraInicio <= auxHInicio)
						auxHInicio = horario.HoraInicio; //limite para banner default

					auxHFin = horario.HoraFin; //cuado ya pasaron todos los horarios
				}
			}

			TimeSpan horaSeg = new TimeSpan(pHora.Hours, pHora.Minutes, 0);

			if (bannerResult == null && auxHInicio != new TimeSpan(23, 59, 0)) //faltan horarios pero ahora es default 
			{
				bannerResult = BannerDefault(horaSeg, auxHInicio);
			}
			else if (BannersDelDia.Count == 0)
			{
				bannerResult = BannerDefault(horaSeg, new TimeSpan(23, 59, 59));
			}
			else //pasaron todos los horarios
			{
				bannerResult = BannerDefault(auxHFin, new TimeSpan(23, 59, 59));
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
					BannerProximo = GetBanner(hora.HoraFin.Add(new TimeSpan(0,1,0)));
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
