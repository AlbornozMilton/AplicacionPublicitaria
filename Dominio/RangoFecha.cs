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
        private List<Dia> iListaDia;
        //private RangoHorario iRangoHorario;

        //CONSTRUCTOR
        public RangoFecha(int pCodRangoFecha, DateTime pFechaInicio, DateTime pFechaFin)
        { 
            //ver como tratar el codigo de rango de fecha
            this.iCodRangoFecha = pCodRangoFecha; 
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
        }

        //PROPIEDADES----------------------------------------------------------
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

        //METODOS----------------------------------------------------------

        public string FechaString(DateTime pFecha)
        {
            return String.Format("{0}/{1}/{2}",pFecha.Day,pFecha.Month,pFecha.Day);
        }

        public void AgregarDia(DateTime pDia)
        {
            //por si se agrega un dia que no este en el rango de fechas preestablecido
            if (!(pDia>=this.iFechaInicio || pDia <= this.iFechaFin))
            {
                throw new Exception();
            }

            this.iListaDia.Add(new Dia(pDia));

        }

    }
}
