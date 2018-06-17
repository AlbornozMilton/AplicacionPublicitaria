﻿using System;
using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

namespace Dominio
{
	public class ControladorBanner
	{
		UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());

		private List<Banner> BannersDelDia = new List<Banner>();
		public Banner BannerActual { get; private set; }
		public Banner BannerProximo { get; private set; }


		public void GenerarBannerFecha(DateTime pDia)
		{
			List<Banner> result = new List<Banner>();
			foreach (var item in iUOfW.RepositorioBanner.BannersEnFecha(pDia.Date))
			{
				result.Add(Mapper.Map<Persistencia.Dominio.Banner, Banner>(item));
			}
			this.BannersDelDia = result;
		}

		public void GetBannerActual(TimeSpan pHora, out int pIntervalo)
		{
			Banner bannerActual = null;
			TimeSpan auxHInicio = new TimeSpan(23, 59, 0), auxHFin = new TimeSpan(23, 59, 59);

			foreach (var banner in BannersDelDia)
			{
				foreach (var horario in banner.RangoFecha.Horarios)
				{
					if (horario.HoraFin <= pHora && horario.HoraFin >= pHora)
					{
						bannerActual = banner; // si le corresponde el horario
						break;
					}
					else if (horario.HoraInicio <= auxHInicio)
						auxHInicio = horario.HoraInicio; //limite para banner default

					auxHFin = horario.HoraFin; //cuado ya pasaron todos los horarios
				}
			}

			TimeSpan intervalo1;
			TimeSpan intervalo2;
			TimeSpan horaSeg = new TimeSpan(pHora.Hours, pHora.Minutes, 0);

			if (bannerActual == null && auxHInicio != new TimeSpan(23, 59, 0)) //faltan horarios pero ahora es default 
			{
				bannerActual = BannerDefault(horaSeg, auxHInicio);
				intervalo1 = horaSeg;
				intervalo2 = auxHInicio;
			}
			else if (BannersDelDia.Count == 0)
			{
				bannerActual = BannerDefault(horaSeg, new TimeSpan(23, 59, 59));
				intervalo1 = horaSeg;
				intervalo2 = new TimeSpan(23, 59, 59);
			}
			else //pasaron todos los horaris
			{
				bannerActual = BannerDefault(auxHFin, new TimeSpan(23, 59, 59));
				intervalo1 = auxHFin;
				intervalo2 = new TimeSpan(23, 59, 59);
			}

			pIntervalo = Convert.ToInt32((intervalo2 - intervalo1).TotalMilliseconds);
			this.BannerActual = bannerActual;
		}

		private Banner BannerDefault(TimeSpan pHoraInicio, TimeSpan pHoraFin)
		{
			RangoFecha rf = new RangoFecha(new RangoHorario(pHoraInicio, pHoraFin));
			return new Banner("Publicidad por defecto", new ControladorFuentes().ObtenerFuenteTextoFijo(null, "FuenteDefault"), rf);
		}

		public string TextoDeFuenteActual(ref int pItem)
		{
			if (pItem + 1 > BannerActual.Fuente.Items.Count)
				pItem = 0;

			var item = BannerActual.Fuente.Items[pItem];

			return ("[" + item.Fecha + "] " + BannerActual.Fuente.Descripcion + ": " + item.Titulo + " - " + item.Texto);
		}

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
