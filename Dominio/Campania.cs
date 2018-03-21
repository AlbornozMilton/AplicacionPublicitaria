using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Campania
    {
        private int iIdCampania;
        private string iNombre;
        private float iDuracion;
        ////////private int iCantCiclos;

        ////////private List<Imagen> iListaImagen;
        ////////private RangoFecha iRangoFecha;


        //////////constructor de la campania
        ////////public Campania()
        ////////{
        ////////    this.iListaImagen = new List<Imagen>();

        ////////}

        public Campania(string pNombre, int pDuracion)
        {
            iNombre = pNombre;
            iDuracion = pDuracion;
        }

        public int CampaniaId
        {
            get { return this.iIdCampania; }
            private set { this.iIdCampania = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            private set { this.iNombre = value; }
        }
        public float Duracion
        {
            get { return this.iDuracion; }
            private set { this.iDuracion = value; }
        }
    }
}
