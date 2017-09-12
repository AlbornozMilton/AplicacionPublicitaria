using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clases;

namespace Persistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicidadContext db = new PublicidadContext();

            //Campania unaCamp = new Campania
            //{
            //    Nombre = "Juli",
            //    Duracion = 15,
            //    CantCiclos = 8
            //};
            //db.Campania.Add(unaCamp);
            //Campania unaCamp = db.Campania.Find(1);
            //Imagen unaim = new Imagen
            //{
            //    Nombre = "im1",
            //    NroSec = 2,
            //    Tiempo = 1,
            //    Campania = unaCamp
            //};
            //db.Imagen.Add(unaim);

            Imagen unaIm = db.Imagen.Find(1);
            Campania unaCamp = unaIm.Campania;
            
            Console.WriteLine(unaCamp.Nombre.ToString());
            //Console.WriteLine("{0} {1} {2}", unaIm.Nombre, unaIm.Id, unaIm.Campania.Id);

            //Campania unaC = db.Campania.Find(index);
            //    Console.WriteLine("{0} {1}", unaC.Nombre,unaC.Id);
            db.SaveChanges();
            Console.WriteLine("EXITO");
            Console.ReadKey();
        }
    }
}
