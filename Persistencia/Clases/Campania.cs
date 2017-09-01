using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clases
{
    public class Campania
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Duracion { get; set; }

        public int CantCiclos { get; set; }

        //ListaImagen

        public RangoFecha RangoFecha { get; set; }
        
    }
}
