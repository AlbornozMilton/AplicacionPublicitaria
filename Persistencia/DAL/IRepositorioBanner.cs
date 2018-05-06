using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(Banner pBanner);
		List<Banner> BannersDelDia(DateTime pDia);

		List<FuenteRSS> FuentesRSS();
		List<TextoFijo> FuentesTextoFijo();
		void AgregarFuente(FuenteRSS pFuente);
		void AgregarFuente(TextoFijo pFuente);
		void ModificarFuente(int pIdFuente, string pNombreFuente);
		void EliminarFuente(int pIdFuente);

		void AgregarItem(int pFuenteId, Item pItem);
		void ModificarItem(Item pItem);
		void EliminarItem(int pItemId);
	}
}
