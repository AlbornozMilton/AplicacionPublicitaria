using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Banner
    {
        //private RangoFecha iRangoFechas 
        private int iIdBanner;
        private string iNombre;
        private IFuente iFuente;
        private RangoFecha iRangoFecha;

        //CONSTRUCTOR--------------------------------------------------------------------------- 
        //////public Banner(int pIdBanner, DateTime pFechaInicio, DateTime pFechaFinal)
        //////{
        //////    this.iIdBanner = pIdBanner;
        //////    this.iNombre = this.iFuente.GetNombreFuente(); //necesario ??
        //////    this.iRangoFecha = new RangoFecha(1, pFechaInicio, pFechaFinal);
        //////}

        // PROPIEDADES ---------------------------------------------------------------------------
        public int BannerId
        {
            get { return this.iIdBanner; }
            private set { this.iIdBanner = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            private set { this.iNombre = value; }
        }

        public RangoFecha RangoFecha
        {
            get { return this.iRangoFecha; }
            private set { this.iRangoFecha = value; }
        }

        //METODOS ---------------------------------------------------------------------------

    }
}
