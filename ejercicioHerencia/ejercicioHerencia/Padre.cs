using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Padre : Abuelo
    {
        public Padre()
        {
            Console.WriteLine("se ha creado un nuevo padre");
        }
        public Padre(string nombre, string apellido) : base (nombre, apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
