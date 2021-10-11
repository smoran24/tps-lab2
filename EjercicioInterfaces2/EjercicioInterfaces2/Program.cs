using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pat = new Pato();
            Boeing747 boe = new Boeing747();
            Superman sup = new Superman();
            TorreDeControl torre = new TorreDeControl();

            torre.agregarVolador(pat);
            torre.agregarVolador(boe);
            torre.agregarVolador(sup);

            torre.vuelenTodos();
            //torre.vuelenTodos(); //lo corro de nuevo para revisar si la condición de cada volador cambió
            Console.ReadKey();
        }
    }
}
