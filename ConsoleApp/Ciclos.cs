using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Ciclos
    {
        public void simples()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1.  Múltiplos");
                Console.WriteLine("2.  Potencias de dos");
                Console.WriteLine("3.  Suma entre números");
                Console.WriteLine("4.  Tabla de multiplicar");
                Console.WriteLine("5.  Divisores");
                Console.WriteLine("6.  Tiempo de viaje");
                Console.WriteLine("7.  Dibujos de asteriscos");
                Console.WriteLine("8.  π");
                Console.WriteLine("9.  Suma de fracciones");
                Console.WriteLine("10. e");
                Console.WriteLine("11. Secuencia de Collatz");
                Console.WriteLine("12. Salir");
                Console.WriteLine("Elige una de las opciones");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine();
                        break;
                    case 11:
                        Console.WriteLine();
                        break;
                    case 12:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 11");
                        break;
                }
            }


        }
    }
}
