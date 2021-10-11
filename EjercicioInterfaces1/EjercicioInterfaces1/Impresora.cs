using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces1
{
    class Impresora
    {
        List<Imprimible> colaDeImpresion = new List<Imprimible>();
        public void ImprimirTodo()
        {
            foreach(Imprimible este in colaDeImpresion){
                este.imprimir();
            }
        }
        public void AgregarImprimible(Imprimible miImprimible)
        {
            colaDeImpresion.Add(miImprimible);
        }
    }
}
