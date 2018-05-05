using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioBanner : Repositorio<Banner, PublicidadContext>, IRepositorioBanner
	{
		public RepositorioBanner(PublicidadContext pContext) : base(pContext)
		{

		}

		/// <summary>
		/// El Rango de Fecha ya paso el control, por lo que debe traer un RangoFechaId existente sino 0.
		/// </summary>
		/// <param name="pBanner"></param>
		public void AgregarBanner(Banner pBanner)
		{
			// tener fuente id


			if (pBanner.RangoFechaId == 0) //rango fecha no existente
			{

			}


		}

		public List<Banner> BannersDelDia(DateTime pFecha)
		{
			// control fecha

			//capturar las fuentes y armarlas segun su tipo

			//devolver con fechas y horarios

			var result = (from b in iDbContext.Banner
						  join frss in iDbContext.FuenteRSS on b.FuenteId equals frss.FuenteId
						  join ftx in iDbContext.TentoFijo on b.FuenteId equals ftx.FuenteId
						  join r in iDbContext.RangoFecha on b.RangoFechaId equals r.RangoFechaId
						  where (r.FechaInicio <= pFecha || r.FechaFin >= pFecha)
						  select b
					 ).ToList();

			//foreach (var fuente in iDbContext.Banner)
			//{
			//	if
			//}
			return result;
		}

		public List<Fuente> TodasLasFuentes()
		{
			return iDbContext.Fuentes.ToList();
		}

		public void ABMFuente(IFuente pFuente, Operacion pOperacion)
		{
			switch (pOperacion)
			{
				case Operacion.Agregar:
					{
						//iDbContext.IFuentes.Add((pFuente));

						//switch (pFuente.TipoFuente)
						//{
						//	case TipoFuente.RSS:
						//		{
						//			iDbContext.IFuentes.Add((pFuente));
						//		}
						//		break;
						//	case TipoFuente.TextoFijo:
						//		{
						//			iDbContext.TentoFijo.Add((TextoFijo)pFuente);
						//		}
						//		break;
						//	default:
						//		throw new Exception("Error en Agregar de ABMFuentes");
						//}
					}
					break;
				case Operacion.Modificar:
					{

					}
					break;
				case Operacion.Eliminar:
					{

					}
					break;
				default:
					throw new Exception("Error de Tipo Fuente en ABMFuentes");
			}

			iDbContext.SaveChanges();
		}
	}
}
