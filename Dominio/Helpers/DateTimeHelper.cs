using System;
using System.Collections.Generic;
using Dominio.Modelos;


namespace Dominio.Helpers
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Comprueba si un horairo esta disponible para agregar un Banner o Campaña
        /// </summary>
        public static void ComprobarHorario(RangoFecha pRangoFecha, TimeSpan pHoraInicio, TimeSpan pHoraFin, string pDias)
        {
            IList<string> mdias = pRangoFecha.Dias.Split('-');

            foreach (string dia in mdias)
            {
                if (pDias.Contains(dia))
                {
                    foreach (var horario in pRangoFecha.Horarios)
                    {
                        if (!(horario.HoraInicio.CompareTo(pHoraInicio) > 0 && horario.HoraInicio.CompareTo(pHoraFin) >= 0)
                        &&
                        (!(horario.HoraFin.CompareTo(pHoraInicio) <= 0 && horario.HoraFin.CompareTo(pHoraFin) < 0)))
                            throw new ApplicationException("Los Horarios y Días elegidos no se encuentran disponibles");
                    }
                }
            }
        }

        //Obtiene los nombres de los dias existentes entre dos fechas
        public static List<string> DiasEntreFechas(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            List<string> listaDias = new List<string>();
            TimeSpan diferencia = pFechaHasta - pFechaDesde;
            for (int i = 0; i <= (diferencia.Days); i++)
            {
                DateTime nuevaFecha = pFechaDesde.AddDays(i);
                if (!listaDias.Contains(nuevaFecha.DayOfWeek.ToString()))
                {
                    listaDias.Add(nuevaFecha.DayOfWeek.ToString());
                }
            }
            return listaDias;
        }


        public static Boolean ControlColisionHorarios(List<RangoHorario> pHorarios, TimeSpan pHoraDesde, TimeSpan pHoraHasta)
        {
            foreach (var rangHor in pHorarios)
            {
                if ((pHoraDesde >= rangHor.HoraInicio && pHoraDesde < rangHor.HoraFin) || (pHoraHasta <= rangHor.HoraFin && pHoraHasta > rangHor.HoraInicio))
                {
                    throw new Exception("El rango ingresado se superpone con otro ya cargado");
                }
            }
            return true;
        }
    }
}
