using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Dia
    {
        private DateTime iDia;
      //  private TimeSpan iHoraInicio;
        //private TimeSpan iHoraFin;
        private DateTime iHoraFinEjemplo;

        //private List<RangoHorario> iListaHorarios;

        //CONSTRUCTOR
      
        public Dia(DateTime pDia, TimeSpan pHoraInicio, int pDuracion)
        {
            this.iDia = pDia.Date;
            this.iHoraFinEjemplo = this.iDia.AddMinutes(pDuracion);
           // this.iHoraInicio = pHoraInicio;
            //this.iHoraFin = this.iHoraInicio.Add(new TimeSpan(0, pDuracion, 0));
            //this.iListaHorarios = new List<RangoHorario>();  <--VER
        }
        //PROPIEDADES
        public DateTime GetDia
        {
            get { return this.iDia.Date; }
            //VER SI SE PUEDE DEVOLVER EL NOMBRE DEL DIA EJ: MIERCOLES
        }

        public int GetHoraInicio
        {
            get { return this.iDia.Hour; }
        }

        public int GetHoraFin
        {
            get { return this.iHoraFinEjemplo.Hour; }
        }

        public int GetDuracion
        {
            get { return this.iHoraFinEjemplo.Subtract(this.iDia).Minutes; }
        }
    }
}
