﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IItem
	{
		string Titulo { get; set; }
		string Texto { get; set; }
		DateTime? Fecha { get; set; }
	}
}
