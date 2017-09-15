﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clases
{
    public class Imagen
    {
        public int ImagenId { get; set; }

        public string Nombre { get; set; }

        public int NroSec { get; set; }

        public int Tiempo { get; set; }

        public int CampaniaId { get; set; }
        
        public Campania Campania { get; set; }
    }
}
