using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    class Superman : Volador
    {
        private int experiencia = 0;
        void Volador.volar()
        {
            Console.WriteLine("Estoy volando como un campeón");
            experiencia = experiencia + 3;
            Console.WriteLine("Superman ahora tiene " + experiencia + " puntos de experiencia");
        }
    }
}
