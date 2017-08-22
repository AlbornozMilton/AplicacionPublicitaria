using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPublicitaria.Dominio
{
    class Campania
    {
        private int iIdCampania;
        private String iNombre;
        private float iDuracion;
        private int iCantCiclos;
        private List<Imagen> iListaImagenes;

        //constructor de la campania
        public Campania()
        {
            this.iListaImagenes = new List<Imagen>();
        }


    }
}
