using Dominio.Helpers;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class CampaniaRangoFecha
    {
        private List<Campania> iCampaniasEnRangoFecha;

        public CampaniaRangoFecha()
        {
            iCampaniasEnRangoFecha = new List<Campania>();
        }

        public CampaniaRangoFecha(List<Campania> pCampaniasEnRangoFecha)
        {
            iCampaniasEnRangoFecha = pCampaniasEnRangoFecha;
        }

        /// <summary>
        /// Actualiza las Campanias que tienen intersección con el rango de fechas elegido para usar como control.
        /// </summary>
        /// 
        public void ActualizarCampanias(List<Campania> pCampanias)
        {
            //por afuera
            //pCampanias = iUOfW.RepositorioCampania.GetCampaniasEntreFechas(pFechaDesde, pFechaHasta)
            foreach (Campania camp in pCampanias)
            {
                iCampaniasEnRangoFecha.Add(camp);
            }
        }

        /// <summary>
        /// Si hay intersección con el Horario y Días, lanza excepción
        /// </summary>
        public void ComprobarHorarioCampania(TimeSpan pHoraInicio, TimeSpan pHoraFin, string pDias)
        {
            foreach (Campania mCampania in iCampaniasEnRangoFecha)
            {
                RangoFecha auxRFecha = mCampania.RangoFecha;
                DateTimeHelper.ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
            }
        }

        public void DescartarCampania(Campania iCampaniaModificar)
        {
            iCampaniasEnRangoFecha.RemoveAll(c => c.CampaniaId == iCampaniaModificar.CampaniaId);
        }
    }
}
