using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscuela
{
    abstract class Persona
    {
        protected int legajo;
        protected string nombre;
        protected string apellido;
        protected string email;
        protected int dni;

        public Persona(int legajo, string nombre, string apellido, string email, int dni)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
        }
    }
}
