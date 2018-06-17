using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
	public interface IRepositorioFuentes : IRepositorio<Fuente>
	{
		List<FuenteRSS> FuentesRSS();
		List<TextoFijo> FuentesTextoFijo();
		TextoFijo ObtenerFuenteTexto(int? IdFuente, string pNombre);
		FuenteRSS ObtenerFuenteRss(int? IdFuente, string pNombre);
		void AgregarFuente(FuenteRSS pFuente);
		void AgregarFuente(TextoFijo pFuente);
		void ModificarFuente(int pIdFuente, string pDescripcion, string pUrl);
		void EliminarFuente(int pIdFuente);
		void AgregarItem(int pFuenteId, Item pItem);
		void ModificarItem(Item pItem);
		void EliminarItem(int pItemId);
		List<Item> ObtenerItemsDeFuente(int pFuente, DateTime? pDesde, DateTime? pHasta);
		void ActualizarItemsRss(List<Item> pItems, int pFuenteId);
	}
}
