using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class FuenteRSSMap: EntityTypeConfiguration<FuenteRSS>
    {
		public FuenteRSSMap()
		{
			//this.Property(pCamp => pCamp.URL)
			//	.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.Property(f => f.Descripcion)
				.IsRequired();

			this.Property(f => f.Descripcion)
				.IsRequired();
		}
    }
}
