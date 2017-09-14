using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clases
{
    public class Imagen
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int NroSec { get; set; }

        public int Tiempo { get; set; }

        //public int Campania_Id { get; set; }
        
        public Campania Campania { get; set; }
    }
}
