using Persistencia.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mapping
{
	class ItemMap : EntityTypeConfiguration<Item>
	{
		/// <summary>
		/// Configuraciones correspondientes a los atributos de Campania
		/// </summary>
		public ItemMap()
		{
			this.Property(i => i.ItemId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.Property(i => i.Titulo)
				.IsRequired();

			this.Property(i => i.Texto)
				.IsRequired();

			//Establece la relacio muchos a 1 con Fuente.
			this.HasRequired(i => i.Fuente)
				.WithMany(f => f.Items);
		}

	}
}
