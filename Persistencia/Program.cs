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
            //    Nombre = "im3",
            //    NroSec = 6,
            //    Tiempo = 10,
            //    Campania = unaCamp
            //};
            //db.Imagen.Add(unaim);

            //var unaIm = db.Imagen.Include("Campania").Where(a => a.Id==1).FirstOrDefault<Imagen>();
            //Console.WriteLine("{0} {1} {2}", unaIm.Nombre, unaIm.Id, unaIm.Campania.Nombre);

            Campania unaCamp = db.Campania.Find(1);
            List<Imagen> lista = unaCamp.Imagenes.ToList();

            foreach (var item in lista)
            {
                Console.WriteLine(item.Nombre);
            }


            db.SaveChanges();
            Console.WriteLine("EXITO");
            Console.ReadKey();
        }
    }
}
