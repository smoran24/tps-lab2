using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces1
{
    class Foto : Imprimible
    {
        void Imprimible.imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
