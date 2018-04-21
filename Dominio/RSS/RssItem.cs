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
		public DateTime? PublishingDate { get; set; }

		public string getTitulo { get { return Title; } set { Title = value; } }
		public string getTexto { get { return Description; } set { Description = value; } }
		public DateTime? getFecha { get { return PublishingDate; } set { PublishingDate = value; } }
	}
}
