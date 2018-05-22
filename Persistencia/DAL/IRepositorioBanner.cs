using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(string pNombre, int pFuenteId, RangoFecha pRFecha);
		List<Banner> BannersDelDia(DateTime pDia);
		List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin);

		List<FuenteRSS> FuentesRSS();
		List<TextoFijo> FuentesTextoFijo();
		void AgregarFuente(FuenteRSS pFuente);
		void AgregarFuente(TextoFijo pFuente);
		void ModificarFuente(int pIdFuente, string pNombreFuente);
		void EliminarFuente(int pIdFuente);
		void AgregarItem(int pFuenteId, Item pItem);
		void ModificarItem(Item pItem);
		void EliminarItem(int pItemId);
		List<Item> ObtenerItemsDeFuente(int pFuente);
	}
}
