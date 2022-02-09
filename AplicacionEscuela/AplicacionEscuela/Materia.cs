using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscuela
{
    class Materia
    {
        private int id;
        private string nombre;
        private string descripcion;

        public Materia(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            List<Nota> notas = new List<Nota>();
            List<Alumno> alumnos = new List<Alumno>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
