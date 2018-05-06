using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

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
		public void AgregarBanner(Banner pBanner)
		{
			// tener fuente id


			if (pBanner.RangoFechaId == 0) //rango fecha no existente
			{

			}


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

		//public IQueryable TodasLasFuentes()
		//{
		//	//return iDbContext.FuenteRSS;
		//	var x = from rss in iDbContext.FuenteRSS select rss;
		//	var z = from rss in iDbContext.TentoFijo select rss;
		//	var y = from rss in iDbContext.Fuentes select rss;

		//	var m = 
		//		( from rss in id

		//		)
		//}

		public List<FuenteRSS> FuentesRSS()
		{
			return iDbContext.FuenteRSS.ToList();
		}

		public List<TextoFijo> FuentesTextoFijo()
		{
			return iDbContext.TentoFijo.ToList();
		}

		public void AgregarFuente(FuenteRSS pFuente)
		{
			iDbContext.FuenteRSS.Add(pFuente);
			iDbContext.SaveChanges();
		}

		public void AgregarFuente(TextoFijo pFuente)
		{
			iDbContext.TentoFijo.Add(pFuente);
			iDbContext.SaveChanges();
		}

		public void ModificarFuente(int pIdFuente, string pNombreFuente)
		{
			var fuente = iDbContext.Fuentes.Find(pIdFuente);

			if (fuente.GetType().Name == "FuenteRSS")
				((FuenteRSS)fuente).URL = pNombreFuente;
			else
				((TextoFijo)fuente).NombreFuente = pNombreFuente;

			iDbContext.SaveChanges();
		}

		public void EliminarFuente(int pIdFuente)
		{
			var fuente = iDbContext.Fuentes.Find(pIdFuente);

			if (fuente.GetType().Name == "FuenteRSS")
				iDbContext.FuenteRSS.Remove(((FuenteRSS)fuente));
			else
				iDbContext.TentoFijo.Remove(((TextoFijo)fuente));

			iDbContext.SaveChanges();
		}
	}
}
