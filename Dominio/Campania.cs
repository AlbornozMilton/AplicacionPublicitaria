using System.Collections.Generic;

namespace Dominio
{
    public class Campania
    {
        private int iIdCampania;
        private string iNombre;
        private int iIntervaloTiempo;

        private List<Imagen> iListaImagen;
        private IEnumerator<Imagen> iEnumeradorListaImg;
        private RangoFecha iRangoFecha;

        /// <summary>
        /// Para el Mapper
        /// </summary>
        public Campania()
        {

        }

        public Campania(string pNombre, int pIntTiempo, RangoFecha pRangoFecha, List<Imagen> pImagenes)
        {
            iNombre = pNombre;
            iIntervaloTiempo = pIntTiempo;
            iRangoFecha = pRangoFecha;
            this.iListaImagen = new List<Imagen>();
            this.iListaImagen = pImagenes;
            //No me gusta lo siguiente
            if (pImagenes != null)
            {
                this.iEnumeradorListaImg = this.iListaImagen.GetEnumerator();
            }
            else
            {
                this.iEnumeradorListaImg = null;
            }
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
        public int IntervaloTiempo
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
            private set
            {   this.iListaImagen = value;
                this.iEnumeradorListaImg = this.iListaImagen.GetEnumerator();
            }
        }


        /// <summary>
        /// Devuelve la siguiente imagen a mostrar (de forma cíclica) 
        /// </summary>
        /// <returns></returns>
        public Imagen SiguienteImagen()
        {
            Imagen imagenSiguiente;
            if (this.iEnumeradorListaImg.MoveNext())
            {
                imagenSiguiente = this.iEnumeradorListaImg.Current;
            }
            else
            {
                this.iEnumeradorListaImg.Reset();
                this.iEnumeradorListaImg.MoveNext();
                imagenSiguiente = this.iEnumeradorListaImg.Current;
            }
            return imagenSiguiente;
        }
    }
}
