﻿using System;
using System.Collections.Generic;
using Dominio.Modelos;


namespace Dominio.Helpers
{
    public static class DateHelper
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
    }
}
