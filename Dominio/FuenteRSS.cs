using Dominio.RSS;

namespace Dominio
{
    public class FuenteRSS: Fuente, IFuente
    {
		private IRssReader ReaderRss { get; }
		private string iUrl;

		public FuenteRSS()
		{

		}

		public FuenteRSS(string pUri)
		{
			iUrl = pUri;
		}

		public string URL { get { return this.iUrl; } private set { this.iUrl = value; } }

		public string NombreFuente { get { return this.iUrl; } private set { this.iUrl = value; } }
	}
}
