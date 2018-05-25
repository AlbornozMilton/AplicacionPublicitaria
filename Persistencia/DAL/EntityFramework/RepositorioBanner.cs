using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public void AgregarItem(int pFuenteId, Item pItem)
		{
			iDbContext.Items.Attach(pItem);
			pItem.FuenteId = pFuenteId;
			iDbContext.Items.Add(pItem);
			iDbContext.SaveChanges();
		}

		public void ModificarItem(Item pItem)
		{
			var item = iDbContext.Items.Where(i => i.ItemId == pItem.ItemId).SingleOrDefault();
			item.Titulo = pItem.Texto;
			item.Texto = pItem.Texto;
			item.Fecha = pItem.Fecha;
			iDbContext.SaveChanges();
		}

		public void EliminarItem(int pItemId)
		{
			var item = iDbContext.Items.Where(i => i.ItemId == pItemId).SingleOrDefault();
			iDbContext.Items.Attach(item);
			iDbContext.Entry(item).State = EntityState.Deleted;
			iDbContext.SaveChanges();
		}

		public void EliminarItem(Item pItem)
		{
			iDbContext.Items.Attach(pItem);
			iDbContext.Entry(pItem).State = EntityState.Deleted;
			iDbContext.SaveChanges();
		}

		public List<Item> ObtenerItemsDeFuente(int pFuente, DateTime pDesde, DateTime pHasta)
		{
				return (
						from i in iDbContext.Items
						join f in iDbContext.Fuentes on i.FuenteId equals f.FuenteId
						where f.FuenteId == pFuente
						&& (i.Fecha >= pDesde && i.Fecha <= pHasta)
						select i).DefaultIfEmpty().ToList(); 
		}

		public List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b => b.RangoFecha.FechaInicio >= pFechaInicio && b.RangoFecha.FechaFin <= pFechaFin)).ToList();
		}
	}
}
