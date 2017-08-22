using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class RangoFecha
    {
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private List<Dia> iListaDias;

        //CONSTRUCTOR
        public RangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
        {
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
        }

        //PROPIEDADES
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
        }
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
        }

        //METODOS
    }
}
