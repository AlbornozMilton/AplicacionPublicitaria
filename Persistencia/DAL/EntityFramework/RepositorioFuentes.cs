using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public void ActualizarItemsRss(List<Item> pItems, int pFuenteId)
		{
			var itemsDB = iDbContext.Items.Where(i => i.FuenteId == pFuenteId).OrderBy(i => i.Fecha).ToList();

			if (itemsDB.Count > 0)
			{
				for (int i = 0; i < pItems.Count; i++)
				{
					if (itemsDB[i].Fecha != pItems[i].Fecha)
					{
						var itemCurrent = pItems[i];
						iDbContext.Items.Attach(itemCurrent);
						itemCurrent.FuenteId = pFuenteId;
						iDbContext.Entry(itemCurrent).State = EntityState.Added;
					}
				}
			}
			else
			{
				foreach (var itemExt in pItems)
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
