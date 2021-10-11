using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    class Boeing747 : Volador
    {
        private int horasVuelo = 0;
        void Volador.volar()
        {
            Console.WriteLine("Estoy volando como un avión");
            horasVuelo = horasVuelo + 13;
            Console.WriteLine("El Boeing 747 sumó en total " + horasVuelo + " horas de vuelo");
        }
    }
}
