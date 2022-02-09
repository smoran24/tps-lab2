using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscuela
{
    class Alumno : Persona
    {
        private string turno;
        public Alumno(string turno, int legajo, string nombre, string apellido, string email, int dni) : base(legajo, nombre, apellido, email, dni)
        {
            this.turno = turno;
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            List<Materia> materias = new List<Materia>();

        }
        public string Turno { get => turno; set => turno = value; }
    }
}
