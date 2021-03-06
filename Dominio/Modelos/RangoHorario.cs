﻿using System;

namespace Dominio.Modelos
{
    public class RangoHorario
    {
        private int iCodRangoHora;
        private TimeSpan iHoraInicio;
        private TimeSpan iHoraFin;

        private RangoFecha iRangoFecha;


        //CONSTRUCTORES --------------------------------------------------------------
        public RangoHorario()
        {

        }

		/// <summary>
		/// Constructor desde la grilla UI Banner. Pasar el 'Value' de cada celda.
		/// </summary>
        public RangoHorario(TimeSpan pHoraInicio , TimeSpan pHoraFin)
        {
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraFin;
		}

        //PROPIEDADES--------------------------------------------------------------
        public int RangoHorarioId
        {
            get { return this.iCodRangoHora; }
            private set { this.iCodRangoHora = value; }
        }

        public TimeSpan HoraInicio
        {
            get { return this.iHoraInicio; }
            private set { this.iHoraInicio = value; }
        }

        public TimeSpan HoraFin
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
