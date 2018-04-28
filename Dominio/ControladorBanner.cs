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

		public void AgregarBanner()
		{

		}
	}
}
