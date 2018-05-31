using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class TextoFijoMap:EntityTypeConfiguration<TextoFijo>
    {
		public TextoFijoMap()
		{
			//this.Property(t => t.NombreFuente)
			//	.IsRequired();
		}
    }
}
