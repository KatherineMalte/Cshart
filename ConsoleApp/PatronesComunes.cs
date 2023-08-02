using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PatronesComunes
    {
        public void comun()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1.  No múltiplos");
                Console.WriteLine("2.  Suma de naturales");
                Console.WriteLine("3.  Número mayor");
                Console.WriteLine("4.  Productos especiales");
                Console.WriteLine("5.  Contar combinaciones de dados");
                Console.WriteLine("6.  Histograma");
                Console.WriteLine("7.  Más corta y más larga");
                Console.WriteLine("8.  Piezas de dominó");
                Console.WriteLine("9.  Lanzar dados");
                Console.WriteLine("10. salir");
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
                }
            }
        }
    }
}
