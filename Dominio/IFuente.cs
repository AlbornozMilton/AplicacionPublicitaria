﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IFuente
	{
		int FuenteId { get; set; }
		string NombreFuente { get; set; }
		TipoFuente TipoFuente { get; set; }
		List<IItem> Items { get; set; }
    }
}
