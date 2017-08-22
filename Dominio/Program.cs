using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nuevo Repositorio 21/08/17
            FuenteRSS lFuenteRSS = new FuenteRSS("Mañana a las 9am","Barrio UTN");
            TextoFijo lTextoFijo = new TextoFijo();

            Console.WriteLine( lFuenteRSS.Texto +" "+ lFuenteRSS.NombreFuente);
            Console.WriteLine(lTextoFijo.Texto);


            Console.ReadKey();
        }
    }
}
