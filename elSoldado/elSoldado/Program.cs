using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu, opcionArma = 0; //lo inicializo porque será tenido en cuenta su valor por el bucle menú principal
            bool salir = false; //permite determinar en qué acción salir del bucle
            Rifle rif = new Rifle("");
            Escopeta esc = new Escopeta("");
            Revolver rev = new Revolver("");
            Soldado sol = new Soldado();
            do
            {
                Console.WriteLine("----Bienvenido al campo de entrenamiento, soldado----");
                Console.WriteLine("¿Qué desea hacer ?");
                Console.WriteLine("(presione el número correspondiente a la opción del menú)");
                Console.WriteLine("[1] Recoger arma");
                Console.WriteLine("[2] Dejar arma");
                Console.WriteLine("[3] Disparar");
                Console.WriteLine("[4] Ver arma en uso");
                Console.WriteLine("[5] Salir");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
                            Console.WriteLine("1 - Revolver");
                            Console.WriteLine("2 - Rifle");
                            Console.WriteLine("3 - Escopeta");
                            Console.WriteLine("4 - Volver atrás");
                            opcionArma = Convert.ToInt32(Console.ReadLine());
                            switch (opcionArma)
                            {
                                case 1:
                                    sol.RecogerArma(rev);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    sol.RecogerArma(rif);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    sol.RecogerArma(esc);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    break; //solo uso el break para salir de este bucle de submenu y volver al principal
                            }
                        } while (opcionArma < 1 || opcionArma > 4);
                        break;
                    case 2:
                        sol.DejarArma();
                        Console.ReadKey();
                        break;
                    case 3:
                        sol.JalarGatillo();
                        Console.ReadKey();
                        break;
                    case 4:
                        sol.VerArma();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Ha escogido salir. Presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        salir = true; //cambia el estado para evitar que el bucle se repita aun después de salir del menú
                        break;
                }
            } while (opcionMenu < 1 || opcionMenu > 5 || salir == false);
        }
    }
}
