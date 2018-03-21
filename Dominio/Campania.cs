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
        private float iIntervaloTiempo;

        private List<Imagen> iListaImagen;
        private RangoFecha iRangoFecha;


        //////////constructor de la campania
        ////////public Campania()
        ////////{
        ////////    this.iListaImagen = new List<Imagen>();

        ////////}

        public Campania(string pNombre, int pIntTiempo)
        {
            iNombre = pNombre;
            iIntervaloTiempo = pIntTiempo;
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
        public float IntervaloTiempo
        {
            get { return this.iIntervaloTiempo; }
            private set { this.iIntervaloTiempo = value; }
        }

        public RangoFecha RangoFecha
        {
            get { return this.iRangoFecha; }
            private set { this.iRangoFecha = value; }
        }

        public List<Imagen> Imagenes
        {
            get { return this.iListaImagen; }
            private set { this.iListaImagen = value; }
        }
    }
}
