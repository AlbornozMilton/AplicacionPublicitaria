using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			this.HasOptional(i => i.Fuente)
				.WithMany(f => f.Items);
		}

	}
}
