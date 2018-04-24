using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL;

namespace Dominio
{
    public class ControladorBanner
    {
		private static List<Banner> BannersDelDia = new List<Banner>();
		private Banner BannerActual { get; }
		private Banner BannerProximo { get; }

		
		public void GenerarBannerDelDia()
		{
			//obtner banner del dia desde BD

			//asigmar tiempo de items de fuente
			//tiempo entre items de fuente: tiempo de publiciadad / cantidad de items

			//para cada fuente
			//	si es RSS obenter feeds
			//		si no se obitnene feeds, obtener anteriores de la bd
			//si no puede establecerse con

			//BannersDelDia = 
		}

		// para cada fin de banner, actualizar bd con sus items

	}
}
