using Dominio.RSS;

namespace Dominio
{
    public class FuenteRSS: Fuente
    {
		private IRssReader ReaderRss { get; }
		//private string Uri;
		/// <summary>
		/// pReader ya resuelto. Guarda Uri. Hacer try/catch
		/// </summary>

		public FuenteRSS()
		{

		}

		/// <summary>
		/// Utilizado para AFM Fuentes
		/// </summary>
		public FuenteRSS(string pUri) : base(pUri, TipoFuente.RSS)
		{
			//ObtenerItems();
		}

		/// <summary>
		/// Utilizado para Capturar Items en Pant. Operativa
		/// </summary>
		public FuenteRSS(string pUri, IRssReader pReader) : base(pUri, TipoFuente.RSS)
		{
			ReaderRss = pReader;
			//Uri = pUri;
			ObtenerItems();
        }

		public void ReLoadItems()
		{
			base.Items.Clear();
			ObtenerItems();
		}

		private void ObtenerItems()
		{
			foreach (var item in ReaderRss.Read(base.NombreFuente))
			{
				base.Items.Add(item);
			}
		}
	}
}
