using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego01b
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables  
            int numAleatorio, numIntroducido;
            int intentosRestantes = 13;
            Random generador = new Random();
            numAleatorio = generador.Next(1, 10001);
            Console.WriteLine("Tienes {0} intentos para adivinar el número aleatorio", intentosRestantes);
            Console.Write("¿Cuál es el número?: ");
            numIntroducido = Convert.ToInt32(Console.ReadLine()); //convierte a entero lo introducido por el usuario, lo cual siempre será string
            //Bucle que se repite hasta que acierte o se quede sin intentos
            while ((numIntroducido != numAleatorio) && (intentosRestantes > 1))
            {
                intentosRestantes--; //resta 1 al contador de intentos
                if (numIntroducido < numAleatorio)
                    Console.WriteLine("Te has quedado corto");
                if (numIntroducido > numAleatorio)
                    Console.WriteLine("Te has pasado");
                Console.WriteLine("Te quedan {0} intentos", intentosRestantes);
                Console.Write("¿Cuál es el número?: ");
                numIntroducido = Convert.ToInt32(Console.ReadLine());
            //Comprobar si gana o pierde
            }
            if (numIntroducido == numAleatorio)
                Console.WriteLine("Has ganado!");
            else
            {
                Console.WriteLine("Has perdido!");
                Console.WriteLine("Era el {0}", numAleatorio);
            }
        }
    }
}

