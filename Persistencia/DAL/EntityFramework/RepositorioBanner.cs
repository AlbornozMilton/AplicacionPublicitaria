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

		/// <summary>
		/// El Rango de Fecha ya paso el control, por lo que debe traer un RangoFechaId existente sino 0.
		/// </summary>
		/// <param name="pBanner"></param>
		public void AgregarBanner(string pNombre, int pFuenteId, RangoFecha pRFecha)
		{
			Banner b = new Banner()
			{
				Nombre = pNombre,
				FuenteId = pFuenteId,
			};

			RangoFecha aux = iDbContext.RangoFecha.Where(h => h.FechaInicio == pRFecha.FechaInicio && h.FechaFin == pRFecha.FechaFin).SingleOrDefault();

			if (aux != null)
				b.RangoFechaId = aux.RangoFechaId;
			else
				b.RangoFecha = pRFecha;

			iDbContext.Banner.Add(b);
			iDbContext.SaveChanges();
		}

		public List<Banner> BannersDelDia(DateTime pFecha)
		{
			// control fecha

			//capturar las fuentes y armarlas segun su tipo

			//devolver con fechas y horarios

			var result = (from b in iDbContext.Banner
						  join frss in iDbContext.FuenteRSS on b.FuenteId equals frss.FuenteId
						  join ftx in iDbContext.TentoFijo on b.FuenteId equals ftx.FuenteId
						  join r in iDbContext.RangoFecha on b.RangoFechaId equals r.RangoFechaId
						  where (r.FechaInicio <= pFecha || r.FechaFin >= pFecha)
						  select b
					 ).ToList();

			//foreach (var fuente in iDbContext.Banner)
			//{
			//	if
			//}
			return result;
		}

		public List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b => !(b.RangoFecha.FechaInicio < pFechaInicio && b.RangoFecha.FechaFin < pFechaInicio)
							||
							!(b.RangoFecha.FechaInicio > pFechaFin && b.RangoFecha.FechaFin > pFechaFin)
							)
				).ToList();
		}
	}
}
