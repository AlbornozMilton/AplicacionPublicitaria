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
            this.iEnumeradorListaImg = this.iListaImagen.GetEnumerator();
            iListaImagen = pImagenes;
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

        /// Devuelve la siguiente imagen a mostrar (de forma cíclica)
        
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
