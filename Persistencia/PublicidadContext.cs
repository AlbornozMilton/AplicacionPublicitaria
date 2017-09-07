using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Persistencia.Clases;
using Persistencia.Mappings;

namespace Persistencia
{
    internal class PublicidadContext:DbContext
    {
        public DbSet <Campania> Campania { get; set; }

        public DbSet <Imagen> Imagen { get; set; }

        public DbSet <RangoFecha> RangoFecha { get; set; }

        public DbSet <Banner> Banner { get; set; }

        public DbSet <RangoHorario> RangoHorario { get; set; }

        public DbSet <Dia> Dia { get; set; }

        public DbSet <Fuente> Fuente { get; set; }

        public DbSet <FuenteRSS> FuenteRSS { get; set; }

        public DbSet <TextoFijo> TextoFijo { get; set; }


        protected override void OnModelCreating(DbModelBuilder mBuilder)
        {
            mBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Elimina las "s" y "es" del nombre de las clases.
            //Mappigs de las configuraciones de las Clases
            mBuilder.Configurations.Add(new CampaniaMap());
            mBuilder.Configurations.Add(new BannerMap());
            mBuilder.Configurations.Add(new ImagenMap());
            mBuilder.Configurations.Add(new DiaMap());
            mBuilder.Configurations.Add(new RangoFechaMap());
            mBuilder.Configurations.Add(new RangoHorarioMap());

            base.OnModelCreating(mBuilder);
        }
    }
}
