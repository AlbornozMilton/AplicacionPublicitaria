using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Dia
    {
        private string iNombreDia;
        private List<RangoHorario> iListaHorarios;

        //CONSTRUCTOR
        public Dia(string pNombreDia)
        {
            this.iNombreDia = pNombreDia;
            //this.iListaHorarios = new List<RangoHorario>();  <--VER
        }
        //PROPIEDADES
        public string NombreDia
        {
            get { return this.iNombreDia; }
        }

        //METODOS
    }
}
