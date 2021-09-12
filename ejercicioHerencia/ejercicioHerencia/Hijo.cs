using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Hijo : Padre
    {
        public Hijo()
        {
            Console.WriteLine("se ha creado un nuevo hijo");
        }
        public Hijo(string nombre, string apellido) : base(nombre, apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
