using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    class Pato : Volador
    {
        private int energia = 100;
        void Volador.volar()
        {
            Console.WriteLine("Estoy volando como un pato. ¡Cuak!");
            energia = energia - 5;
            Console.WriteLine("El pato tiene ahora un total de " + energia + " puntos de energía");
        }
    }
}
