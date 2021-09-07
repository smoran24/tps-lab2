using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opcion, resultado;
            do
            {
                Console.WriteLine("Ingrese el primer número entero: ");
                num1 = Convert.ToInt32(Console.ReadLine()); //convierte a entero el valor que ingrese el usuario en ReadLine (String)
                Console.WriteLine("Ingrese el segundo número entero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escoja una operación:");
                Console.WriteLine("[1] Sumar");
                Console.WriteLine("[2] Restar");
                Console.WriteLine("[3] Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion < 1 || opcion > 3);
            switch (opcion)
            {
                case 1:
                    resultado = Operacion.sumar(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 2:
                    resultado = Operacion.restar(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("Gracias por usar la herramienta.");
                    break;
            }
            Console.Read();
        }
    }
}
