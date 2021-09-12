using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Abuelo
    {
        protected String nombre;
        protected String apellido;
        public Abuelo()
        {
            Console.WriteLine("se ha creado un nuevo abuelo");
        }
        public Abuelo(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
    }

}
