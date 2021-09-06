using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Sebastián", "Morán"); //creo un objeto persona que usará el constructor sobrecargado
            Console.WriteLine("Nombre: " + per1.getNombre() + ", apellido: " + per1.getApellido());
            
            Persona per2 = new Persona(); //creo un nuevo objeto persona que usará el constructor vacío.
            per2.setNombre("José");
            per2.setApellido("Honguito");
            

            Domicilio dom1 = new Domicilio("G.Godoy", 123);
            per2.setViveEn(dom1);
            Console.WriteLine("Nombre: " + per2.getNombre() + ", apellido: " + per2.getApellido() + ", vive en: "+per2.getViveEn().getCalle() + per2.getViveEn().getNumero());

            Console.Read(); //sirve para evitar que se cierre la consola
        }
    }
}
