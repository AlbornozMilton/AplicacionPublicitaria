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
        private TimeSpan iHoraInicio;
        private int iDuracion; //en minutos

        //CONSTRUCTORES --------------------------------------------------------------
        public RangoHorario(int pCodRangoHora,TimeSpan pHoraInicio ,int pDuracion)
        {
            this.iCodRangoHora = pCodRangoHora;
            this.iHoraInicio = pHoraInicio;
            this.iDuracion = pDuracion;
        }
        //PROPIEDADES--------------------------------------------------------------
        public int CodRangoHora
        {
            get { return this.iCodRangoHora; }
        }

        public TimeSpan HoraFin
        {
           get { return this.iHoraInicio.Add(new TimeSpan(0, this.iDuracion, 0)); }
        //buscar como instanciar TimeSpan teniendo en cuento los ticks y minutos
        // get { return this.iHoraInicio.Add(new TimeSpan(0,this.iDuracion,0)); }
        }

        public string HoraInicioString
        {
            get { return String.Format("{0}-{1}-{2}", this.iHoraInicio.Hours, this.iHoraInicio.Minutes, this.iHoraInicio.Seconds); }
                
        }

        public string HoraFinString
        {
            get { return String.Format("{0}-{1}-{2}", this.HoraFin.Hours, this.HoraFin.Minutes, this.HoraFin.Seconds); }

        }

        //METODOS --------------------------------------------------------------

    }
}
