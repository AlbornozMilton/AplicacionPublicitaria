using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class RangoHorario
    {
        private DateTime iHoraInicio;
        private DateTime iHoraFin;

        //CONSTRUCTOR
        public RangoHorario(DateTime pHoraInicio, DateTime pHoraFin)
        {
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraFin;
        }
        //PROPIEDADES
        public DateTime HoraInicio
        {
            get { return this.iHoraInicio; }
        }
        public DateTime HoraFin
        {
            get { return this.iHoraFin; }
        }
        //METODOS
    }
}
