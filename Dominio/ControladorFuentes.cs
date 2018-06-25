using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

namespace Dominio
{
	public class ControladorFuentes
	{
		UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());

		public enum Operacion
		{
			Agregar,
			Modificar,
			Eliminar
		}

		public string GetTipoFuente(int IdFuente)
		{
			return iUOfW.RepositorioFuentes.ObtenerTipoFuente(IdFuente);
		}

		public TextoFijo ObtenerFuenteTextoFijo(int? IdFuente, string pNombre)
		{
			return (Mapper.Map<Persistencia.Dominio.TextoFijo, TextoFijo>(iUOfW.RepositorioFuentes.ObtenerFuenteTexto(IdFuente,pNombre)));
		}

		public FuenteRSS ObtenerFuenteRss(int? IdFuente, string pNombre)
		{
			return (Mapper.Map<Persistencia.Dominio.FuenteRSS, FuenteRSS>(iUOfW.RepositorioFuentes.ObtenerFuenteRss(IdFuente, pNombre)));
		}

		public void ABMFuente(Operacion pOperacion, string pTipo, int pFuenteId, string pDescripcion, string pUrl)
		{
			switch (pOperacion)
			{
				case Operacion.Agregar:
					{
						if (pTipo == "FuenteRss")
							iUOfW.RepositorioFuentes.AgregarFuente
								(
								 new Persistencia.Dominio.FuenteRSS { Descripcion = pDescripcion, URL = pUrl }
								);
						else
							iUOfW.RepositorioFuentes.AgregarFuente
								(
								 new Persistencia.Dominio.TextoFijo { Descripcion = pDescripcion }
								);
					}
					break;
				case Operacion.Modificar:
					{
						iUOfW.RepositorioFuentes.ModificarFuente(pFuenteId, pDescripcion, pUrl);
					}
					break;
				case Operacion.Eliminar:
					{
						iUOfW.RepositorioFuentes.EliminarFuente(pFuenteId);
					}
					break;
			}
		}

		/// <summary>
		/// Fuentes con sus Items
		/// </summary>
		/// <returns></returns>
		public List<IFuente> ObtenerFuentes()
		{
			List<IFuente> resultado = new List<IFuente>();

			foreach (var fuente in iUOfW.RepositorioFuentes.FuentesRSS())
			{
				resultado.Add(Mapper.Map<Persistencia.Dominio.FuenteRSS, FuenteRSS>(fuente));
			}

			foreach (var fuente in iUOfW.RepositorioFuentes.FuentesTextoFijo())
			{
				resultado.Add(Mapper.Map<Persistencia.Dominio.TextoFijo, TextoFijo>(fuente));
			}

			return resultado.ToList();
		}

		public void ABMItems(Operacion pOP, int pFuenteId, IItem pItem)
		{
			switch (pOP)
			{
				case Operacion.Agregar:
					{
						iUOfW.RepositorioFuentes.AgregarItem(pFuenteId, Mapper.Map<IItem, Persistencia.Dominio.Item>(pItem));
					}
					break;
				case Operacion.Modificar:
					{
						iUOfW.RepositorioFuentes.ModificarItem(Mapper.Map<IItem, Persistencia.Dominio.Item>(pItem));

					}
					break;
				case Operacion.Eliminar:
					{
						iUOfW.RepositorioFuentes.EliminarItem(pItem.ItemId);
					}
					break;
			}
		}

		public List<ItemGenerico> ItemsFuenteTexto(int pFuente, DateTime? pDesde, DateTime? pHasta)
		{
			List<ItemGenerico> lista = new List<ItemGenerico>();
			foreach (var item in iUOfW.RepositorioFuentes.ObtenerItemsDeFuente(pFuente, pDesde, pHasta))
			{
				lista.Add(Mapper.Map<Persistencia.Dominio.Item, ItemGenerico>(item));
			}
			return lista;
		}

		public List<RSS.RssItem> ItemsFuenteRss(int pFuenteId, DateTime? pDesde, DateTime? pHasta)
		{
			List<RSS.RssItem> lista = new List<RSS.RssItem>();
			foreach (var item in iUOfW.RepositorioFuentes.ObtenerItemsDeFuente(pFuenteId, pDesde, pHasta))
			{
				lista.Add(Mapper.Map<Persistencia.Dominio.Item, RSS.RssItem>(item));
			}
			return lista;
		}

		public void ActualizarItemsRss(List<RSS.RssItem> pItems, int pFuenteId)
		{
			List<Persistencia.Dominio.Item> lista = new List<Persistencia.Dominio.Item>();
			foreach (var item in pItems)
			{
				lista.Add(Mapper.Map<RSS.RssItem, Persistencia.Dominio.Item>(item));
			}
			iUOfW.RepositorioFuentes.ActualizarItemsRss(lista.OrderBy(i => i.Fecha).ToList(), pFuenteId);
		}

	}
}
