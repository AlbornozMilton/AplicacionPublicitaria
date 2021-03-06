﻿using System;
using Dominio.Interfaces;

namespace Dominio.RSS
{
	public class RssItem : IItem
	{
		public int ItemId { get; set; }
		/// <summary>
		/// Título del ítem.
		/// </summary>
		public String Titulo { get; set; }

		/// <summary>
		/// Descripción acerca del ítem.
		/// </summary>
		public String Texto { get; set; }

		/// <summary>
		/// URL del ítem.
		/// </summary>
		public Uri Url { get; set; }

		/// <summary>
		/// Fecha de publicación.
		/// </summary>
		public DateTime Fecha { get; set; }

		//public string Titulo { get { return Title; } set { Title = value; } }
		//public string Texto { get { return Description; } set { Description = value; } }
		//public DateTime Fecha { get { return PublishingDate; } set { PublishingDate = value; } }
	}
}
