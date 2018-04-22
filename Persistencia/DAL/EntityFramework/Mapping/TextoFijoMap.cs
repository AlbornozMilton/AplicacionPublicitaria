using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class TextoFijoMap:EntityTypeConfiguration<TextoFijo>
    {
		public TextoFijoMap()
		{
			this.Property(pCamp => pCamp.Nombre)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			//this.Property(pCamp => pCamp.Texto)
			//	.IsRequired();
		}
    }
}
