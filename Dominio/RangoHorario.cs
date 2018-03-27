using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RangoHorario
    {
        private int iCodRangoHora;
        private DateTime iHoraInicio;
        private DateTime iHoraFin; //TIMESPAN ???

        private RangoFecha iRangoFecha;


        //CONSTRUCTORES --------------------------------------------------------------
        public RangoHorario(int pCodRangoHora,DateTime pHoraInicio ,int pDuracion)
        {
            this.iCodRangoHora = pCodRangoHora;
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraInicio.Add(new TimeSpan(0, pDuracion, 0));
        }
        //PROPIEDADES--------------------------------------------------------------
        public int RangoHorarioId
        {
            get { return this.iCodRangoHora; }
            private set { this.iCodRangoHora = value; }
        }

        public DateTime HoraInicio
        {
            get { return this.iHoraInicio; }
            private set { this.iHoraInicio = value; }
        }

        public DateTime HoraFin
        {
            get { return this.iHoraFin; }
            private set { this.iHoraFin = value; }
        }

        public RangoFecha RangoFecha
        {
            get { return this.iRangoFecha; }
            private set { this.iRangoFecha = value; }
        }


        //////public TimeSpan HoraFin
        //////{
        //////   get { return this.iHoraInicio.Add(new TimeSpan(0, this.iDuracion, 0)); }
        ////////buscar como instanciar TimeSpan teniendo en cuento los ticks y minutos
        //////// get { return this.iHoraInicio.Add(new TimeSpan(0,this.iDuracion,0)); }
        //////}

        ////////public string HoraInicioString
        ////////{
        ////////    get { return String.Format("{0}-{1}-{2}", this.iHoraInicio.Hours, this.iHoraInicio.Minutes, this.iHoraInicio.Seconds); }

        ////////}

        ////////public string HoraFinString
        ////////{
        ////////    get { return String.Format("{0}-{1}-{2}", this.HoraFin.Hours, this.HoraFin.Minutes, this.HoraFin.Seconds); }

        ////////}

        //METODOS --------------------------------------------------------------

    }
}
