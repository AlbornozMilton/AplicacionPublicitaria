using System;
using Dominio.Modelos;

namespace Dominio.Modelos
{
    public class Imagen
    {
        private int iIdImagen;
        private String iNombre;
        private int iNumSecuencia;
        private string iRuta;
        private Campania iCampania;

        public int ImagenId
        {
            get { return this.iIdImagen; }
            private set { this.iIdImagen = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            private set { this.iNombre = value; }
        }
        public int NumSecuencia
        {
            get { return this.iNumSecuencia; }
            private set { this.iNumSecuencia = value; }
        }
        public string Ruta
        {
            get { return this.iRuta; }
            private set { this.iRuta = value; }
        }

        public Campania Campania
        {
            get { return this.iCampania; }
            private set { this.iCampania = value; }
        }

        public Imagen()
        {

        }
        public Imagen (string pNombre, string pRuta)
        {
            this.iNombre = pNombre;
            this.iRuta = pRuta;
        }
    }
}