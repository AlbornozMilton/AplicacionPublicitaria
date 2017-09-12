using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clases;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.Mappings
{
    class DiaMap : EntityTypeConfiguration<Dia>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de Dia.
        /// </summary>
        public DiaMap()
        {
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(d => d.Nombre)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
