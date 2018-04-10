using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class DiaMap : EntityTypeConfiguration<Dia>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de Dia.
        /// </summary>
        public DiaMap()
        {
            this.Property(d => d.DiaId)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(d => d.Nombre)
                .IsRequired();

            this.HasMany(d => d.RangosFechas)
                .WithMany(f => f.Dias);

        }
    }
}
