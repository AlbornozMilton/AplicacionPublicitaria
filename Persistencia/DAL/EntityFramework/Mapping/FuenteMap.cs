using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework.Mapping
{
	class FuenteMap : EntityTypeConfiguration<Fuente>
	{
		public FuenteMap()
		{
			this.Property(pCamp => pCamp.FuenteId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			//this.HasMany<Item>(C => C.Items)
			//	.WithRequired(C => C.Fuente)
			//	.WillCascadeOnDelete();

			//this.Property(pCamp => pCamp.NombreFuente)
			//	.IsRequired();

			//this.Property(pCamp => pCamp.TipoFuente)
			//	.IsRequired();
		}
	}
}
