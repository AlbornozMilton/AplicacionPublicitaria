namespace Persistencia.Dominio
{
    public class FuenteRSS: Fuente, IFuente
	{
        public string URL { get; set; }

		public string NombreFuente { get { return URL; } set { this.URL = value; } }
	}
}
