using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
            Electrodomestico elec1 = new Electrodomestico(300, "azul", 'E', 100);
            Lavadora lav1 = new Lavadora(); //deberia valer 120
            Lavadora lav2 = new Lavadora(45, 200, 50); //deberia valer 340 (no 290)
            Television tv1 = new Television(); //deberia valer 120
            Television tv2 = new Television(45, true, 500, 17); //deberia valer 1014 (no 520)
            //electrodomesticos.Add(elec1);
            electrodomesticos.Add(lav1);
            electrodomesticos.Add(lav2);
            electrodomesticos.Add(tv1);
            electrodomesticos.Add(tv2);
            Console.WriteLine("Lavadoras: ");
            foreach(Electrodomestico este in electrodomesticos)
            {
                if (este is Lavadora)
                {
                    este.precioFinal();
                    Console.WriteLine("Precio: " + este.getPrecioBase());
                }
            }
            /*
            foreach (Lavadora esteLav in electrodomesticos.OfType<Lavadora>()) //foreach que recorre la lista que contiene clases Electrodomesticos pero solo tiene en cuenta las subclases Lavadora
            {
                esteLav.precioFinal();
                Console.WriteLine("Precio: " + esteLav.getPrecioBase());
                
            }
            */

            Console.WriteLine("Televisores: ");
            foreach (Electrodomestico este in electrodomesticos)
            {
                if (este is Television)
                {
                    este.precioFinal();
                    Console.WriteLine("Precio: " + este.getPrecioBase());
                }
            }
            /*
            foreach (Television esteTV in electrodomesticos.OfType<Television>()) //foreach que recorre la lista que contiene clases Electrodomesticos pero solo tiene en cuenta las subclases Television
            {
                esteTV.precioFinal();
                Console.WriteLine("Precio: " + esteTV.getPrecioBase());

            }
            */

            int sumatoria = 0;
            foreach (Electrodomestico este in electrodomesticos)
            {
                sumatoria = sumatoria + este.getPrecioBase();
            }
            Console.WriteLine("El sumatoria total de los precios es de: " + sumatoria);
            Console.ReadKey();
        }
    }
}
