﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class EstructurasCondicionales
    {
        public void condicion()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Determinar par");
                Console.WriteLine("2. Años bisiestos");
                Console.WriteLine("3. División");
                Console.WriteLine("4. Palabra más larga");
                Console.WriteLine("5. Ordenamiento");
                Console.WriteLine("6. Letra o número");
                Console.WriteLine("7. Calculadora");
                Console.WriteLine("8. Edad");
                Console.WriteLine("9. Set de tenis");
                Console.WriteLine("10. Triángulos");
                Console.WriteLine("11. Índice de masa corporal");
                Console.WriteLine("11. Salir");
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
