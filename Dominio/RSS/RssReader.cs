using System;
using System.Collections.Generic;

namespace Dominio.RSS
{
	public abstract class RssReader: IRssReader
	{
		public IEnumerable<RssItem> Read(String pUrl)
		{
			if (String.IsNullOrWhiteSpace(pUrl))
			{
				throw new ArgumentException("pUrl");
			}

			return this.Read(new Uri(pUrl));
		}

		public abstract IEnumerable<RssItem> Read(Uri pUrl);
	}
}
