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

		/// <summary>
		/// El Rango de Fecha ya paso el control, por lo que debe traer un RangoFechaId existente sino 0.
		/// </summary>
		/// <param name="pBanner"></param>
		public void AgregarBanner(int BannerMod, string pNombre, int pFuenteId, RangoFecha pRFecha)
		{
			Banner b;

			if (BannerMod != 0)
				b = iDbContext.Banner.Where(ban => ban.BannerId == BannerMod).FirstOrDefault();
			else
				b = new Banner();

			b.FuenteId = pFuenteId;
			b.Nombre = pNombre;

			RangoFecha rfDB = iDbContext.RangoFecha.Where(h => h.FechaInicio == pRFecha.FechaInicio && h.FechaFin == pRFecha.FechaFin).SingleOrDefault();
			if (rfDB != null)
			{
				rfDB.Dias = pRFecha.Dias;
				iDbContext.RangoHorario.RemoveRange(rfDB.Horarios);
				rfDB.Horarios = pRFecha.Horarios;
			}
			else
			{
				b.RangoFechaId = 0;
				b.RangoFecha = pRFecha;
				foreach (RangoHorario item in pRFecha.Horarios)
				{
					if (item.RangoFecha != null)
					{
						item.RangoFecha = null;
						item.RangoHorarioId = 0;
					}
				}
			}

			if (BannerMod == 0)
				iDbContext.Banner.Add(b);

			iDbContext.SaveChanges();
		}

		public List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b =>
							!(b.RangoFecha.FechaInicio < pFechaInicio && b.RangoFecha.FechaFin < pFechaInicio)
							||
							!(b.RangoFecha.FechaInicio > pFechaFin && b.RangoFecha.FechaFin > pFechaFin)
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
			Banner banner = iDbContext.Banner.Where(b => b.BannerId == IdBanner).FirstOrDefault();
			iDbContext.Entry(banner).State = EntityState.Deleted;
			iDbContext.SaveChanges();
		}
	}
}
