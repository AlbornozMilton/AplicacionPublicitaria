using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia.Clases;

namespace Persistencia
{
    internal class PublicidadContext:DbContext
    {
        public DbSet <Campania> Campania { get; set; }

        public DbSet <Imagen> Imagen { get; set; }

        public DbSet <>
    }
}
