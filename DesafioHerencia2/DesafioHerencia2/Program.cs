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
            Lavadora lav2 = new Lavadora(45, 200, 50); //deberia valer 340
            Television tv1 = new Television(); //deberia valer 120
            Television tv2 = new Television(45, true, 500, 17); //deberia valer 1014
            //electrodomesticos.Add(elec1);
            electrodomesticos.Add(lav1);
            electrodomesticos.Add(lav2);
            electrodomesticos.Add(tv1);
            electrodomesticos.Add(tv2);
            Console.WriteLine("Lavadoras: ");
            foreach(Electrodomestico este in electrodomesticos)
            {
                if (este is Lavadora) //condicion a ejecutar si el objeto Electrodomestico "este" es de subclase Lavadora
                {
                    este.precioFinal();
                    Console.WriteLine("Precio: " + este.getPrecioBase());
                }
            }

            Console.WriteLine("Televisores: ");
            foreach (Electrodomestico este in electrodomesticos)
            {
                if (este is Television) //condicion a ejecutar si el objeto Electrodomestico "este" es de subclase Television
                {
                    este.precioFinal();
                    Console.WriteLine("Precio: " + este.getPrecioBase());
                }
            }

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
