using System;
using System.Collections.Generic;
using System.Data.Entity;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    public class DatabaseInitializationStrategy: CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
			TextoFijo f = new TextoFijo
			{
				Descripcion = "PublicApp",
				Items = new List<Item>
				{
					new Item
					{
						Fecha = DateTime.Now,
						Titulo = "Elija su Título",
						Texto = "Coloque contenido exclusivo."
					}
				}
			};

			context.Set<TextoFijo>().Add(f);

			base.Seed(context);
        }
    }
}
