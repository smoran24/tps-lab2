using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces1
{
    class Contrato : Imprimible 
    {
        void Imprimible.imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
