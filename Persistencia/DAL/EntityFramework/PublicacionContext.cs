using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Persistencia.Dominio;

[assembly: InternalsVisibleTo("Dominio")]

namespace Persistencia.DAL.EntityFramework
{
    class PublicacionContext: DbContext
    {
        public PublicacionContext():base("AplicacionPublicitariaDB")
        {
        }

        //ATRIBUTOS       
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<> Ciudad { get; set; }
        public virtual DbSet<> Cupo { get; set; }
        public virtual DbSet<> Domicilio { get; set; }
        public virtual DbSet<> Habitacion { get; set; }
        public virtual DbSet<> LineaServicio { get; set; }
        public virtual DbSet<> Pago { get; set; }
        public virtual DbSet<> Servicio { get; set; }

        protected override void OnModelCreating(DbModelBuilder mBuilder)
        {
            mBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Elimina las "s" y "es" del nombre de las clases.
            //Mappigs de las configuraciones de las Clases
            /*
            mBuilder.Configurations.Add(new AlojamientoMap());
            mBuilder.Configurations.Add(new CiudadMap());
            mBuilder.Configurations.Add(new ClienteMap());
            mBuilder.Configurations.Add(new CupoMap());
            mBuilder.Configurations.Add(new DomicilioMap());
            mBuilder.Configurations.Add(new HabitacionMap());
            mBuilder.Configurations.Add(new LineaServicioMap());
            mBuilder.Configurations.Add(new PagoMap());
            mBuilder.Configurations.Add(new TarifaClienteMap());
            */
            base.OnModelCreating(mBuilder);
        }
    }
}
