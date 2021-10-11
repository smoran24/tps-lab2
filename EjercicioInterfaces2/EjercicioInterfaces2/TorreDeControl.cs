using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    class TorreDeControl
    {
        List<Volador> misVoladores = new List<Volador>();
        public void vuelenTodos()
        {
            foreach(Volador este in misVoladores)
            {
                este.volar();
            }
        }
        public void agregarVolador(Volador miVolador)
        {
            misVoladores.Add(miVolador);
        }
    }
}
