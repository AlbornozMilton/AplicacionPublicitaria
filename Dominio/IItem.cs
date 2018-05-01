using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IItem
	{
		string getTitulo { get; set; }
		string getTexto { get; set; }
		DateTime? getFecha { get; set; }
	}
}
