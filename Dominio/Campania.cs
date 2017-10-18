using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Campania
    {
        private int iIdCampania;
        private string iNombre;
        private float iDuracion;
        private int iCantCiclos;

        private List<Imagen> iListaImagen;
        private RangoFecha iRangoFecha;


        //constructor de la campania
        public Campania()
        {
            this.iListaImagen = new List<Imagen>();

        }

    }
}
