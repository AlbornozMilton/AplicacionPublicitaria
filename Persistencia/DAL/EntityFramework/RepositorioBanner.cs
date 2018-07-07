using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.Dominio;
using System.Data.Entity;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioBanner : Repositorio<Banner, PublicidadContext>, IRepositorioBanner
	{
		public RepositorioBanner(PublicidadContext pContext) : base(pContext)
		{

		}

		public List<Banner> BannersEnFecha(DateTime pFecha)
		{
			string diaString = "";
			switch (pFecha.DayOfWeek)
			{
				case DayOfWeek.Sunday:
					diaString = "domingo";
					break;
				case DayOfWeek.Monday:
					diaString = "lunes";
					break;
				case DayOfWeek.Tuesday:
					diaString = "martes";
					break;
				case DayOfWeek.Wednesday:
					diaString = "miercoles";
					break;
				case DayOfWeek.Thursday:
					diaString = "jueves";
					break;
				case DayOfWeek.Friday:
					diaString = "viernes";
					break;
				case DayOfWeek.Saturday:
					diaString = "sabado";
					break;
			}
                                                                   //ACA MODIFIQUE |
                                                                   //              V     
			var bannersReturn = iDbContext.Banner.Include("Fuente").Include("Fuente.Items").Include("RangoFecha.Horarios").Where(
				b => (b.RangoFecha.FechaInicio <= pFecha && b.RangoFecha.FechaFin >= pFecha) && b.RangoFecha.Dias.Contains(diaString)).ToList();

			return bannersReturn;
		}

		/// <summary>
		/// El Rango de Fecha ya paso el control, por lo que debe traer un RangoFechaId existente sino 0.
		/// </summary>
		/// <param name="pBanner"></param>
		public void AgregarBanner(string pNombre, int pFuenteId, RangoFecha pRFecha)
		{
			foreach (RangoHorario item in pRFecha.Horarios)
			{
				item.RangoFecha = null;
				item.RangoHorarioId = 0;
			}

			Banner b = new Banner()
			{
				BannerId = 0,
				Nombre = pNombre,
				FuenteId = pFuenteId,
				Fuente = null,
				RangoFechaId = 0,
				RangoFecha = pRFecha,
			};

			iDbContext.Banner.Add(b);
			iDbContext.SaveChanges();
		}

		public void ModificarBanner(int pIdBanner, string pNombre, int pFuenteId, RangoFecha pRFecha)
		{
			EliminarBanner(pIdBanner);
			AgregarBanner(pNombre, pFuenteId, pRFecha);
		}

		public List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b =>
							//!(b.RangoFecha.FechaInicio < pFechaInicio && b.RangoFecha.FechaFin < pFechaInicio)
							//||
							//!(b.RangoFecha.FechaInicio > pFechaFin && b.RangoFecha.FechaFin > pFechaFin)
							(b.RangoFecha.FechaFin >= pFechaInicio && b.RangoFecha.FechaFin <= pFechaFin)
							||
							(b.RangoFecha.FechaInicio >= pFechaInicio && b.RangoFecha.FechaInicio <= pFechaFin)
							||
							(b.RangoFecha.FechaInicio <= pFechaInicio && b.RangoFecha.FechaFin >= pFechaFin)
				)).ToList();
		}

		public List<Banner> BuscarBanner(string pNombre, DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b => (b.Nombre.Contains(pNombre) || pNombre == null)
							&&
							(b.RangoFecha.FechaInicio >= pFechaInicio && b.RangoFecha.FechaFin <= pFechaFin)
				)).ToList();
		}

		public void EliminarBanner(int IdBanner)
		{
			Banner banner = iDbContext.Banner.Where(b => b.BannerId == IdBanner).SingleOrDefault();
			RangoFecha rf = iDbContext.RangoFecha.Where(f => f.RangoFechaId == banner.RangoFechaId).SingleOrDefault();
			iDbContext.Entry(banner).State = EntityState.Deleted;
			iDbContext.Entry(rf).State = EntityState.Deleted;
			iDbContext.SaveChanges();
		}
	}
}
