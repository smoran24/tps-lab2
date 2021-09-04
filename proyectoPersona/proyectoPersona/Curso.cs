using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPersona
{
    class Curso
    {
        private String nombre;
        private int cantAlumnos;
        private Persona esAlumno;
        public Curso()
        {
        }
        public Curso(string nombre, int cantAlumnos)
        {
            this.nombre = nombre;
            this.cantAlumnos = cantAlumnos;
        }

    }
}
