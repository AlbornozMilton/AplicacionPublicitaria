using Common.Logging;
using System;
using System.Collections.Generic;
using Terradue.ServiceModel.Syndication;
using System.Xml;

namespace Dominio.RSS
{
	public class SyndicationFeedRssReader : RssReader
	{

		/// <summary>
		/// Definición de logger para todas las instancias de la clase.
		/// </summary>
		private static readonly ILog cLogger = LogManager.GetLogger<SyndicationFeedRssReader>();

		public override IEnumerable<RssItem> Read(Uri pUrl)
		{
			if (pUrl == null)
			{
				throw new ArgumentNullException("pUrl");
			}

			cLogger.Info("Obteniendo feeds...");
			cLogger.DebugFormat("Obteniendo feeds desde {0}...", pUrl.AbsoluteUri);
			XmlReader mReader = XmlReader.Create(pUrl.AbsoluteUri);
			SyndicationFeed mFeed = SyndicationFeed.Load(mReader);

			IList<RssItem> mRssItems = new List<RssItem>();

			cLogger.Info("Ha finalizado la obtención de feeds.");
			cLogger.DebugFormat("Se ha(n) obtenido {0} feed(s).", mRssItems.Count);

			cLogger.Info("Adaptando feeds...");
			foreach (SyndicationItem bItem in mFeed.Items)
			{
				mRssItems.Add(new RssItem
				{
					Titulo = bItem.Title.Text,
					Texto = bItem.Summary.Text,
					Url = bItem.Links[0].Uri, // Siempre obtengo la primera URL, por más que haya más de una.
					Fecha = bItem.PublishDate.DateTime
				});
			}

			cLogger.Info("Devolviendo feeds adaptados...");
			return mRssItems;
		}

	}
}
