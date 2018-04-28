using System;

namespace Dominio.RSS
{
	public class RssItem:IItem
	{
		/// <summary>
		/// Título del ítem.
		/// </summary>
		public String Title { get; set; }

		/// <summary>
		/// Descripción acerca del ítem.
		/// </summary>
		public String Description { get; set; }

		/// <summary>
		/// URL del ítem.
		/// </summary>
		public Uri Url { get; set; }

		/// <summary>
		/// Fecha de publicación.
		/// </summary>
		public DateTime PublishingDate { get; set; }

		public string Titulo { get { return Title; } set { Title = value; } }
		public string Texto { get { return Description; } set { Description = value; } }
		public DateTime Fecha { get { return PublishingDate; } set { PublishingDate = value; } }
	}
}
