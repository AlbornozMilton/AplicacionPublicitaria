using System;
using System.Collections.Generic;
	/*  int result = lFecha1.ComapreTo(lFecha2);  o bien--> int result = lFecha1.Date.ComapreTo(lFecha2.Date);
        result = -1 : Fecha1 es menor que Fecha2 
        result =  0 : Fecha1 es igual que Fecha2
        result = +1 : Fecha1 es menor que Fecha2 */
namespace Dominio
{
   public class RangoFecha
    {
        private int iCodRangoFecha;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
		private string iDias;
        private List<RangoHorario> iRangoHorario;
        private Campania iCampania;

        //CONSTRUCTOR
        public RangoFecha()
        {

        }
        public RangoFecha(DateTime pFechaInicio, DateTime pFechaFin, string pDias, List<RangoHorario>pHorarios)
        { 
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
			this.iDias = pDias;
            this.iRangoHorario = pHorarios;
        }
        /// <summary>
        /// Metodo para devolver las campañas actual y siguiente con el unico horario necesario
        /// </summary>
        /// <param name="pRangoH"></param>
        public RangoFecha(RangoHorario pRangoH)
        {
            this.iFechaInicio = DateTime.Today.Date;
            this.iFechaFin = DateTime.Today.Date;
            this.iRangoHorario = new List<RangoHorario>();
            iRangoHorario.Add(pRangoH);
        }

        public Campania Campania
        {
            get { return this.iCampania; }
            private set { this.iCampania = value; }
        }
        public int RangoFechaId
        {
            get { return this.iCodRangoFecha; }
            private set { this.iCodRangoFecha = value; }
        }

        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            private set { this.iFechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            private set { this.iFechaFin = value; }
        }

		public string Dias
		{
			get { return this.iDias; }
			private set { this.iDias = value; }
		}

		public List<RangoHorario> Horarios
        {
            get { return this.iRangoHorario; }
            private set { this.iRangoHorario = value; }
        }
        
		//METODOS----------------------------------------------------------
        public string FechaString(DateTime pFecha)
        {
            return String.Format("{0}/{1}/{2}",pFecha.Day,pFecha.Month,pFecha.Day);
        }

		public RangoFecha AgregarHorario(RangoHorario pRangoH)
		{
			this.Horarios = new List<RangoHorario>();
			this.Horarios.Add(pRangoH);
            return this;
        }
    }
}
