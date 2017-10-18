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
        private TimeSpan iHoraFin;
        private int iDuracion; //en minutos

        //CONSTRUCTORES --------------------------------------------------------------
        public RangoHorario(int pCodRangoHora,TimeSpan pHoraInicio ,int pDuracion)
        {
            this.iCodRangoHora = pCodRangoHora;
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraInicio.Add(new TimeSpan(0, pDuracion, 0));
            this.iDuracion = pDuracion;
        }
        //PROPIEDADES--------------------------------------------------------------
        public int CodRangoHora
        {
            get { return this.iCodRangoHora; }
        }

        public int Duracion
        {
            get { return this.HoraFin.Subtract(this.iHoraInicio).Minutes; }
          //  get { return this.iDuracion; }
        }
        // segun lo que se elige se elimina o cambio get de HoraFin o Duracion
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
