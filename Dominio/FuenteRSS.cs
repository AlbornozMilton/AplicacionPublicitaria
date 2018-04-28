using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
