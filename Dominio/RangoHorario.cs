using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class RangoHorario
    {
        private int iCodRangoHora;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private List<Dia> iDias;

        //CONSTRUCTOR
        public RangoHorario(int pCodRangoHora, DateTime pFechaInicio, DateTime pFechaFin)
        {
            this.iCodRangoHora = pCodRangoHora;
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
        }
        //PROPIEDADES
        public int CodRangoHora
        {
            get { return this.iCodRangoHora; }
        }

        public TimeSpan HoraFin
        {
            get { return this.iHoraInicio.Add(new TimeSpan(0,this.iDuracion,0)); }
        }

        public string HoraInicioString
        {
            get { return String.Format("{0}-{1}-{2}", this.iHoraInicio.Hours, this.iHoraInicio.Minutes, this.iHoraInicio.Seconds); }
                
        }

        public string HoraFinString
        {
            get { return String.Format("{0}-{1}-{2}", this.HoraFin.Hours, this.HoraFin.Minutes, this.HoraFin.Seconds); }

        }

        //METODOS
    }
}
