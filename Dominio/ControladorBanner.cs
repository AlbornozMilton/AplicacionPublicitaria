using System;
using System.Collections.Generic;
using System.Linq;
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
			
		}

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
	}
}
