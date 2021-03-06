﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Persistencia.Dominio;
using Persistencia.DAL.EntityFramework.Mapping;

//[assembly: InternalsVisibleTo("Dominio")]

namespace Persistencia.DAL.EntityFramework
{
    public class PublicidadContext : DbContext
    {
        public PublicidadContext() : base("PublicidadDB")
        {
            Database.SetInitializer<PublicidadContext>(new DatabaseInitializationStrategy());
			}

        //ATRIBUTOS       
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<Campania> Campania { get; set; }
		public virtual DbSet<Imagen> Imagen { get; set; }
        public virtual DbSet<RangoFecha> RangoFecha { get; set; }
        public virtual DbSet<RangoHorario> RangoHorario { get; set; }
		public virtual DbSet<Fuente> Fuentes { get; set; }
		public virtual DbSet<FuenteRSS> FuenteRSS { get; set; }
		public virtual DbSet<TextoFijo> TextoFijo { get; set; }
		public virtual DbSet<Item> Items { get; set; }


		protected override void OnModelCreating(DbModelBuilder mBuilder)
        {
            mBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Elimina las "s" y "es" del nombre de las clases.
                                                                           //Mappigs de las configuraciones de las Clases

            mBuilder.Configurations.Add(new BannerMap());
            mBuilder.Configurations.Add(new CampaniaMap());
            mBuilder.Configurations.Add(new ImagenMap());
            mBuilder.Configurations.Add(new RangoFechaMap());
            mBuilder.Configurations.Add(new RangoHorarioMap());
			mBuilder.Configurations.Add(new FuenteMap());
			mBuilder.Configurations.Add(new TextoFijoMap());
			mBuilder.Configurations.Add(new FuenteRSSMap());
			mBuilder.Configurations.Add(new ItemMap());

			base.OnModelCreating(mBuilder);
        }
    }
}