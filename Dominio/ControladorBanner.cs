using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL;
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


		public void GenerarBannerDelDia()
		{
			//obtner banner del dia desde BD
			var x = iUOfW.RepositorioBanner.BannersDelDia(DateTime.Now.Date);
			//asigmar tiempo de items de fuente
			//tiempo entre items de fuente: tiempo de publiciadad / cantidad de items

			//para cada fuente
			//	si es RSS obenter feeds
			//		si no se obitnene feeds, obtener anteriores de la bd
			//si no puede establecerse con

			//BannersDelDia = 
		}

		// para cada fin de banner, actualizar bd con sus items

		// formatear texto devolver
		public string TextoDeFuenteActual()
		{
			return "Texto de prueba, mañana se denelas llenaasdasda asd asd asd asdasd ssdasda sd asda sd asd asd asd asd asd asd s papaaa....12313";
		}

		public void AgregarBanner(string pNombre, int pIdFuente,DateTime pRFDesde, DateTime pRFHasta, List<RangoHorario> pRHorarios, string pDias)
		{
			RangoFecha rf = new RangoFecha(pRFDesde, pRFHasta, pDias, pRHorarios);
			var rfMapped = Mapper.Map <RangoFecha, Persistencia.Dominio.RangoFecha>(rf);
			iUOfW.RepositorioBanner.AgregarBanner(pNombre, pIdFuente, rfMapped);
		}

		public enum Operacion
		{
			Agregar,
			Modificar,
			Eliminar
		}

		public void ABMFuente(Operacion pOperacion, string pTipo, int pFuenteId, string pNombreFuente)
		{
			switch (pOperacion)
			{
				case Operacion.Agregar:
					{
						if (pTipo == "RSS")
							iUOfW.RepositorioBanner.AgregarFuente
								(
								 new Persistencia.Dominio.FuenteRSS { URL = pNombreFuente }
								);
						else
							iUOfW.RepositorioBanner.AgregarFuente
								(
								 new Persistencia.Dominio.TextoFijo { NombreFuente = pNombreFuente }
								);
					}
					break;
				case Operacion.Modificar:
					{
						iUOfW.RepositorioBanner.ModificarFuente(pFuenteId, pNombreFuente);
					}
					break;
				case Operacion.Eliminar:
					{
						iUOfW.RepositorioBanner.EliminarFuente(pFuenteId);
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

			foreach (var fuente in iUOfW.RepositorioBanner.FuentesRSS())
			{
				resultado.Add(Mapper.Map<Persistencia.Dominio.FuenteRSS, FuenteRSS>(fuente));
			}

			foreach (var fuente in iUOfW.RepositorioBanner.FuentesTextoFijo())
			{
				resultado.Add(Mapper.Map<Persistencia.Dominio.TextoFijo, TextoFijo>(fuente));
			}

			return resultado.OrderBy(f => f.NombreFuente).ToList();
		}

		public void ABMItems(Operacion pOP, int pFuenteId, IItem pItem)
		{
			switch (pOP)
			{
				case Operacion.Agregar:
					{
						iUOfW.RepositorioBanner.AgregarItem(pFuenteId, Mapper.Map<IItem, Persistencia.Dominio.Item>(pItem));
					}
					break;
				case Operacion.Modificar:
					{
						iUOfW.RepositorioBanner.ModificarItem(Mapper.Map<IItem, Persistencia.Dominio.Item>(pItem));

					}
					break;
				case Operacion.Eliminar:
					{
						iUOfW.RepositorioBanner.EliminarItem(pItem.ItemId);
					}
					break;
			}
		}

		public List<ItemGenerico> ItemsFuenteTexto(int pFuente, DateTime pDesde, DateTime pHasta)
		{
			List<ItemGenerico> lista = new List<ItemGenerico>();
			foreach (var item in iUOfW.RepositorioBanner.ObtenerItemsDeFuente(pFuente, pDesde.Date, pHasta.Date))
			{
				lista.Add(Mapper.Map<Persistencia.Dominio.Item, ItemGenerico>(item));
			}
			return lista;
		}

		public List<RSS.RssItem> ItemsFuenteRss(int pFuenteId, DateTime pDesde, DateTime pHasta)
		{
			List<RSS.RssItem> lista = new List<RSS.RssItem>();
			foreach (var item in iUOfW.RepositorioBanner.ObtenerItemsDeFuente(pFuenteId, pDesde.Date, pHasta.Date))
			{
				lista.Add(Mapper.Map<Persistencia.Dominio.Item, RSS.RssItem>(item));
			}
			return lista;
		}
	}
}
