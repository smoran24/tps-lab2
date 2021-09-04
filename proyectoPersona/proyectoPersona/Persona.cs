using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPersona
{
    class Persona
    {
        private String nombre;
        private String apellido;
        private Domicilio viveEn;
        private Curso cursaEn;
        public Persona() //constructor vacío
        {

        }
        public Persona(String nombre, String apellido) //constructor sobrecargado
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getApellido()
        {
            return this.apellido;
        }
        public Domicilio getViveEn()
        {
            return this.viveEn;
        }
        public void setNombre(String nom)
        {
            this.nombre = nom;
        }
        public void setApellido(String ape)
        {
            this.apellido = ape;
        }
        public void setViveEn(Domicilio vive)
        {
            this.viveEn = vive;
        }
    }
    
}
