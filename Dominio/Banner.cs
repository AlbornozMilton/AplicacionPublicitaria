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
        private string iNombre;
        private Fuente iFuente;
        private RangoFecha iRangoFecha;


        //contructor 
        public Banner(int pIdBanner, string pNombre)
        {
            this.iIdBanner = pIdBanner;
            this.iNombre = pNombre;
        }
    }
}
