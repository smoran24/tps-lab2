using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato con1 = new Contrato();
            Foto fot1 = new Foto();
            Documento doc1 = new Documento();
            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(con1);
            impresora.AgregarImprimible(fot1);
            impresora.AgregarImprimible(doc1);
            impresora.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
