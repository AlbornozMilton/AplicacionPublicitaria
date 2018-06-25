using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.Dominio;
using System.Data.Entity;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioFuentes : Repositorio<Fuente, PublicidadContext>, IRepositorioFuentes
	{
		public RepositorioFuentes(PublicidadContext pContext) : base(pContext)
		{

		}

		public List<FuenteRSS> FuentesRSS()
		{
			return iDbContext.FuenteRSS.ToList();
		}

		public List<TextoFijo> FuentesTextoFijo()
		{
			return iDbContext.TextoFijo.ToList();
		}

		public string RssUrl(int FuenteId)
		{
			var fuenteRss = iDbContext.FuenteRSS.Where(f => f.FuenteId == FuenteId).SingleOrDefault();
			if (fuenteRss != null)
				return fuenteRss.URL;
			return "";
		}

		public TextoFijo ObtenerFuenteTexto(int? IdFuente, string pNombre)
		{
			return (
					from f in iDbContext.TextoFijo.Include("Items")
					where (f.FuenteId == IdFuente || IdFuente == null)
					&& (f.Descripcion == pNombre || pNombre == "")
					select f).SingleOrDefault();
		}

		public FuenteRSS ObtenerFuenteRss(int? IdFuente, string pNombre)
		{
			return (
					from f in iDbContext.FuenteRSS.Include("Items")
					where (f.FuenteId == IdFuente || IdFuente == null)
					&& (f.Descripcion == pNombre || pNombre == "")
					select f).SingleOrDefault();
		}

		public void AgregarFuente(FuenteRSS pFuente)
		{
			iDbContext.FuenteRSS.Add(pFuente);
			iDbContext.SaveChanges();
		}

		public void AgregarFuente(TextoFijo pFuente)
		{
			iDbContext.TextoFijo.Add(pFuente);
			iDbContext.SaveChanges();
		}

		public void ModificarFuente(int pIdFuente, string pDescripcion, string pUrl)
		{
			var fuente = iDbContext.Fuentes.Find(pIdFuente);

			if (fuente.GetType().Name == "FuenteRSS")
			{
				((FuenteRSS)fuente).Descripcion = pDescripcion;
				((FuenteRSS)fuente).URL = pUrl;
			}
			else
				((TextoFijo)fuente).Descripcion = pDescripcion;

			iDbContext.SaveChanges();
		}

		public void EliminarFuente(int pIdFuente)
		{
			var fuente = iDbContext.Fuentes.Find(pIdFuente);
			iDbContext.Fuentes.Remove(fuente);
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
			item.Titulo = pItem.Titulo;
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

		public List<Item> ObtenerItemsDeFuente(int pFuente, DateTime? pDesde, DateTime? pHasta)
		{
			return (
					from i in iDbContext.Items
					join f in iDbContext.Fuentes on i.FuenteId equals f.FuenteId
					where f.FuenteId == pFuente
					&& ((i.Fecha >= pDesde && i.Fecha <= pHasta) || (pDesde == null && pHasta == null))
					select i).ToList();
		}

		public List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
		{
			return (
				iDbContext.Banner.Include("RangoFecha.Horarios").Include("Fuente")
				.Where(b => b.RangoFecha.FechaInicio >= pFechaInicio && b.RangoFecha.FechaFin <= pFechaFin)).ToList();
		}

		public void ActualizarItemsRss(List<Item> pItems, int pFuenteId)
		{
			//var itemsDB = iDbContext.Items.Where(i => i.FuenteId == pFuenteId).OrderBy(i => i.Fecha).ToList();
			var ultIFechaItem = iDbContext.Items.Last().Fecha;

			//if (itemsDB.Count > 0)
			//	iDbContext.Items.RemoveRange(itemsDB);

			foreach (var itemExt in pItems)
			{
				if (itemExt.Fecha > ultIFechaItem)
				{
					iDbContext.Items.Attach(itemExt);
					itemExt.FuenteId = pFuenteId;
					iDbContext.Entry(itemExt).State = EntityState.Added; 
				}
			}

			iDbContext.SaveChanges();
		}
	}
}
