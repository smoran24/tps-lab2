using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPersona
{
    class Persona
    {
        protected String nombre;
        protected String apellido;
        protected Domicilio viveEn;
        protected Curso cursaEn;
        public Persona() //constructor vacío
        {

        }
        public Persona(String nombre, String apellido, String calle, int numero) //constructor sobrecargado
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.viveEn = new Domicilio(calle, numero); //establece relacion de composición entre Persona y Domicilio
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
        public Curso getCursaEn()
        {
            return this.cursaEn;
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
        public void setCursaEn(Curso cursa)
        {
            this.cursaEn = cursa;
        }

    }
    
}
