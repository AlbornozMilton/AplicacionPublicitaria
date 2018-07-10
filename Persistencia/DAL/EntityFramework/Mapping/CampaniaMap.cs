using Persistencia.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class CampaniaMap : EntityTypeConfiguration<Campania>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de Campania
        /// </summary>
        public CampaniaMap()
        {
            this.Property(pCamp => pCamp.CampaniaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pCamp => pCamp.Nombre)
                .IsRequired();

            this.Property(pCamp => pCamp.IntervaloTiempo)
                .IsRequired();

            this.HasMany<Imagen>(C => C.Imagenes)
                .WithRequired(I => I.Campania)
                .Map(pMapping => pMapping.MapKey("CampaniaId"))
                .WillCascadeOnDelete();

            //Establece la relacion 1 a 1 con RangoFecha.
            this.HasRequired<RangoFecha>(pCamp => pCamp.RangoFecha)
                .WithRequiredPrincipal(r => r.Campania)  //en este caso siempre se requiere la clave foranea a la campania, y puede ser q no la tenga si es solo el rango de una banner
                .Map(pMapping => pMapping.MapKey("CampaniaId"))
                .WillCascadeOnDelete();

            //this.HasRequired<RangoFecha>(pCamp => pCamp.RangoFecha)
            //    .WithOptional(r => r.Campania)              //deberia ser asi, porque hay rangos que solo van a tener banner asociado
            //y la clave foranea a la campania podria ser nula. Nose porque no anda
            //    .Map(pMapping => pMapping.MapKey("CampaniaId"))
            //    .WillCascadeOnDelete();
        }

    }
}
