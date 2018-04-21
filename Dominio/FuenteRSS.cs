using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RSS;

namespace Dominio
{
    public class FuenteRSS: Fuente, IFuente
    {
		private IRssReader ReaderRss { get; }
		/// <summary>
		/// pReader ya resuelto. Guarda Uri. Hacer try/catch
		/// </summary>
		public FuenteRSS(string pUri, IRssReader pReader) : base(pUri, TipoFuente.RSS)
		{
			ReaderRss = pReader;
			foreach (var item in pReader.Read(pUri))
			{
				base.Items.Add(item);
			}
        }
	}
}
