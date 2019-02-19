using System;
namespace Dominio.Interfaces
{
	public interface IItem
	{
		int ItemId { get; set; }
		string Titulo { get; set; }
		string Texto { get; set; }
		DateTime Fecha { get; set; }
	}
}
