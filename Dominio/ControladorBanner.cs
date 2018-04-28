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
			RangoHorario horario = new RangoHorario(new TimeSpan(4, 0, 0), new TimeSpan(4, 10, 0));
			RangoFecha rangoFecha = new RangoFecha(DateTime.Now.Date, DateTime.Now.Date.AddDays(1),
				new List<Dia>() { new Dia("Lunes") }, new List<RangoHorario>() { horario});

			IItem item = new ItemGenerico("Titulo Empresa",
				"Texto de prueba, mañana se denelas llenaasdasda asd asd asd asdasd ssdasda sd asda sd asd asd asd asd asd asd s papaaa....12313"
				, DateTime.Now);

			List<IItem> items = new List<IItem>() {item};

			IFuente fuente = new TextoFijo("Taller Default",items);

			Banner BannerLogic = new Banner("Empresa Taller de Prog",fuente,rangoFecha);

			Persistencia.Dominio.Banner perBanner = Mapper.Map<Banner,Persistencia.Dominio.Banner>(BannerLogic);

			iUOfW.RepositorioBanner.AgregarBanner(perBanner);
		}
	}
}
