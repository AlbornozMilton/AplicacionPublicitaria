using Dominio.Helpers;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class BannerRangoFecha
    {
        private List<Banner> iBannersEnRangoFecha;

        public BannerRangoFecha()
        {
            iBannersEnRangoFecha = new List<Banner>();
        }

        public BannerRangoFecha(List<Banner> pBannersEnRangoFecha)
        {
            iBannersEnRangoFecha = pBannersEnRangoFecha;
        }

        /// <summary>
        /// Actualiza los Banners que tienen intersección con el rango de fechas elegido para usar como control.
        /// </summary>
        public void ActualizarBanners(int pBannerExcluido, List<Banner> pBanners)
        {
            ////por afuera
            //pBanners = iUOfW.RepositorioBanner.BannersEnRangoFecha(pFechaDesde.Date, pFechaHasta.Date)
            iBannersEnRangoFecha.Clear();
            foreach (Banner banner in pBanners)
            {
                if (banner.BannerId != pBannerExcluido)
                    iBannersEnRangoFecha.Add(banner);
                //Mapper.Map<Persistencia.Dominio.Banner, Banner>(banner)
            }
        }

        /// <summary>
        /// Si hay intersección con el Horario y Días, lanza excepción
        /// </summary>
        public void ComprobarHorarioBanner(List<RangoHorario> pHorarios, string pDias)
        {
            foreach (Banner mBanner in iBannersEnRangoFecha)
            {
                if (mBanner.RangoFecha != null)
                {
                    RangoFecha auxRFecha = mBanner.RangoFecha;
                    foreach (RangoHorario item in pHorarios)
                    {
                        DateTimeHelper.ComprobarHorario(auxRFecha, item.HoraInicio, item.HoraFin, pDias);
                    }
                }
            }
        }
    }
}
