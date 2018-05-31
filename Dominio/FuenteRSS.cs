﻿using Dominio.RSS;
using System.Collections.Generic;

namespace Dominio
{
    public class FuenteRSS: Fuente
    {
		private string iUrl;

		public FuenteRSS()
		{

		}

		public FuenteRSS(string pUri)
		{
			iUrl = pUri;
		}

		public string URL { get { return this.iUrl; } private set { this.iUrl = value; } }
	}
}
