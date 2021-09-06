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

        public String getNombre()
        {
            return this.nombre;
        }
        public int getCantAlumnos()
        {
            return this.cantAlumnos;
        }
        public Persona getEsAlumno()
        {
            return this.esAlumno;
        }
        public void setNombre(String nom)
        {
            this.nombre = nom;
        }
        public void setCantAlumnos(int cantAl)
        {
            this.cantAlumnos = cantAl;
        }
        public void setEsAlumno(Persona alu)
        {
            this.esAlumno = alu;
        }
    }
}
