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

            this.HasRequired(pCamp => pCamp.RangoFecha);

        }

    }
}
