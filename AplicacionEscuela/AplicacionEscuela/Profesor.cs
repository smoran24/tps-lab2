using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscuela
{
    class Profesor : Persona
    {
        private int anioIncorporacion;
        public Profesor(int anioIncorporacion, int legajo, string nombre, string apellido, string email, int dni) : base(legajo, nombre, apellido, email, dni)
        {
            this.anioIncorporacion = anioIncorporacion;
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            List<Materia> materias = new List<Materia>();

        }
        public int AnioIncorporacion { get => anioIncorporacion; set => anioIncorporacion = value; }
    }
}
