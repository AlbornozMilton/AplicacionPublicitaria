using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
     int result = lFecha1.ComapreTo(lFecha2);  o bien--> int result = lFecha1.Date.ComapreTo(lFecha2.Date);
        
        result = -1 : Fecha1 es menor que Fecha 2 
        result =  0 : Fecha1 es igual que Fecha 2
        result = +1 : Fecha1 es menor que Fecha 2
     
     */

namespace Dominio
{
    class RangoFecha
    {
        private int iCodRangoFecha;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private RangoHorario iRangoHorario;


        //CONSTRUCTOR
        public RangoFecha(int pCodRangoFecha, DateTime pFechaInicio, DateTime pFechaFin, RangoHorario pRangoHorario)
        {
            this.iCodRangoFecha = pCodRangoFecha;
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
            this.iRangoHorario = pRangoHorario;
        }

        //PROPIEDADES
        public int CodFecha
        {
            get { return this.iCodRangoFecha; }

        }

        public DateTime FechaInicio
        {
            get { return this.iFechaInicio.Date; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaFin.Date; }
        }

        public RangoHorario RangoHorario
        {
            get { return this.iRangoHorario; }
        }

        //METODOS

        public string FechaString(DateTime pFecha)
        {
            return String.Format("{0}/{1}/{2}",pFecha.Day,pFecha.Month,pFecha.Day);
        }

        

    }
}
