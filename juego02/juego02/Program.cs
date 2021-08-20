using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace juego02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            float incr1 = 0.5f;
            int x = 40, y = 12;
            int xo1 = 20, yo1 = 15; // Obstáculo 1
            int xo2 = 25, yo2 = 5; // Obstáculo 2
            int xo3 = 62, yo3 = 21; // Obstáculo 3
            float xe1 = 32, ye1 = 23;
            int fin = 0; // 0 = no terminado, 1 = terminado
            while (fin == 0)
            {
                // Dibujar
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("A");
                Console.SetCursorPosition(xo1, yo1); // Obstáculos
                Console.Write("o");
                Console.SetCursorPosition(xo2, yo2);
                Console.Write("o");
                Console.SetCursorPosition(xo3, yo3);
                Console.Write("o");
                Console.SetCursorPosition((int)xe1, (int)ye1); // Enemigo
                Console.Write("@");
                // Leer teclas y calcular nueva posición
                tecla = Console.ReadKey(false);
                if (tecla.Key == ConsoleKey.RightArrow) x++;
                if (tecla.Key == ConsoleKey.LeftArrow) x--;
                if (tecla.Key == ConsoleKey.DownArrow) y++;
                if (tecla.Key == ConsoleKey.UpArrow) y--;
                xe1 = xe1 + incr1;
                if ((xe1 == 0) || (xe1 == 79))
                {
                    incr1 = -incr1;
                }
                if (((x==xo1) && (y==yo1)) || ((x == xo2) && (y == yo2)) || ((x == xo3) && (y == yo3)))
                {
                    fin = 1;
                }
                Thread.Sleep(40);
            }
        }
    }
}
