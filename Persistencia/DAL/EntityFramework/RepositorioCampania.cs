using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCampania : Repositorio<Campania, PublicidadContext>, IRepositorioCampania
    {
        public RepositorioCampania(PublicidadContext pContext) : base(pContext)
        {

        }
        public override Campania Get(int pIdCampania)
        {
            return iDbContext.Campania.Include("Imagenes").Where(c => c.CampaniaId == pIdCampania).SingleOrDefault();
        }

        public override IEnumerable<Campania> GetAll()
        {
            return (iDbContext.Campania.Include("Imagenes").Include("RangoFecha").Include("RangoFecha.Horarios")).ToList();/*.Dias*/
    
		}

        public IEnumerable<Campania> GetFiltradas(Dictionary<Type, object> pFiltros)
        {
            string pNombre = (string)pFiltros[typeof(string)];
            var campanias = from camp in this.iDbContext.Campania.Include("RangoFecha").Include("Imagenes")
                            where camp.Nombre.Contains(pNombre)
                            select camp;
            if (pFiltros.ContainsKey(typeof(RangoFecha)))
            { 
                List<Campania> resultado = new List<Campania>();
                RangoFecha pRangoFecha = (RangoFecha)pFiltros[typeof(RangoFecha)];
                DateTime fechaInicio = pRangoFecha.FechaInicio.Date;
                DateTime fechaFin = pRangoFecha.FechaFin.Date;
                foreach (var camp in campanias)
                {
                    if ((camp.RangoFecha.FechaInicio.CompareTo(fechaInicio) <= 0 && camp.RangoFecha.FechaFin.CompareTo(fechaInicio) >= 0) ||
                        (camp.RangoFecha.FechaInicio.CompareTo(fechaFin) <= 0 && camp.RangoFecha.FechaFin.CompareTo(fechaFin) >= 0) ||
                        (camp.RangoFecha.FechaInicio.CompareTo(fechaInicio) >= 0 && camp.RangoFecha.FechaFin.CompareTo(fechaFin) <= 0))
                    {
                        resultado.Add(camp);
                    }
                }
                return resultado;
            }
            else
            {
                return campanias.ToList();
            }
        }

        public IEnumerable<Campania> GetCampaniasEntreFechas(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            var campanias = from camp in (this.iDbContext.Campania.Include("RangoFecha.Horarios").Include("RangoFecha"))
                            where ((camp.RangoFecha.FechaFin >= pFechaDesde && camp.RangoFecha.FechaFin <= pFechaHasta)
                            ||
                            (camp.RangoFecha.FechaInicio >= pFechaDesde && camp.RangoFecha.FechaInicio <= pFechaHasta)
                            ||
                            (camp.RangoFecha.FechaInicio <= pFechaDesde && camp.RangoFecha.FechaFin >= pFechaHasta))
                            select camp;
            return campanias.ToList();
        }

		public IEnumerable<Campania> GetCampaniasParaElDia(DateTime pDia)
		{
			string diaString = "";
			switch (pDia.DayOfWeek)
			{
				case DayOfWeek.Sunday:
					diaString = "domingo";
					break;
				case DayOfWeek.Monday:
					diaString = "lunes";
					break;
				case DayOfWeek.Tuesday:
					diaString = "martes";
					break;
				case DayOfWeek.Wednesday:
					diaString = "miercoles";
					break;
				case DayOfWeek.Thursday:
					diaString = "jueves";
					break;
				case DayOfWeek.Friday:
					diaString = "viernes";
					break;
				case DayOfWeek.Saturday:
					diaString = "sabado";
					break;
			}

			var campanias = from camp in (this.iDbContext.Campania.Include("Imagenes").Include("RangoFecha.Horarios")).Include("RangoFecha")/*.Dias*/
							where ((pDia >= camp.RangoFecha.FechaInicio && pDia <= camp.RangoFecha.FechaFin) 
							&& camp.RangoFecha.Dias.Contains(diaString))
							//&& (camp.RangoFecha.Dias.Where(d => d.Nombre == pDia.DayOfWeek.ToString())).Count() != 0)
                            select camp;
            return campanias.ToList();
        }
    }
}
