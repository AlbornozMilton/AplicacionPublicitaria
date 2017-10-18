using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Banner
    {
        //private RangoFecha iRangoFechas 
        private int iIdBanner;
        private string iNombreBanner;
        private ITextoFuente iFuente;
        private RangoFecha iRangoFecha;



        //contructor 
        public Banner(int pIdBanner, DateTime pFechaInicio, DateTime pFechaFinal)
        {
            this.iIdBanner = pIdBanner;
            this.iNombreBanner = this.iFuente.GetNombreFuente(); //necesario ??
            this.iRangoFecha = new RangoFecha(1, pFechaInicio, pFechaFinal);
        }

        public string GetNombreBanner { get { return this.iFuente.GetNombreFuente(); } }

        //ver! - nombre fuente quedaria mejor ?
        public string GetNombreBanner2 { get { return this.iNombreBanner; } }

    }
}
