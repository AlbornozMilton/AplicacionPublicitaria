using System;
namespace Dominio
{
	public interface IItem
	{
		int ItemId { get; set; }
		string Titulo { get; set; }
		string Texto { get; set; }
		DateTime Fecha { get; set; }
	}
}
