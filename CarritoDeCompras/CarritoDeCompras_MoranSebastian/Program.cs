using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_MoranSebastian
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu;
            char salir = 'N';
            Carrito car = new Carrito();
            do
            {
                Console.WriteLine("-SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1 - Añadir camisa al carro de compras");
                Console.WriteLine("2 - Eliminar camisa del carro de compras");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("- Cantidad de camisas en el carro de compras: " + car.getCantCamisas());
                Console.WriteLine("- Precio unitario: $1000");
                Console.WriteLine("- Precio total sin descuento: $" + car.getPrecioFinalSinDesc());
                Console.WriteLine("- Tipo de descuento aplicado: %" + car.getDescuento());
                Console.WriteLine("- Precio final con descuento: $" + car.getPrecioFinal());
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú:");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        car.addCamisa();
                        Console.ReadKey();
                        break;
                    case 2:
                        car.deleteCamisa();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Está seguro que desea salir? S/N");
                        salir = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                        break;
                }
            } while (opcionMenu < 1 || opcionMenu > 3 || salir == 'N');
        }
    }
    
}
