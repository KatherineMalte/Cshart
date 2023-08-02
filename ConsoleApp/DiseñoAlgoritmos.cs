using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DiseñoAlgoritmos
    {

        public void algoritmo()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1.  Dígitos");
                Console.WriteLine("2.  Dígito verificador");
                Console.WriteLine("3.  Ecuación primer grado");
                Console.WriteLine("4.  Caballo de ajedrez");
                Console.WriteLine("5.  Media armónica");
                Console.WriteLine("6.  Números palíndromos");
                Console.WriteLine("7.  Palabras palíndromas");
                Console.WriteLine("8.  Cachipún");
                Console.WriteLine("9.  Números primos");
                Console.WriteLine("10. El mejor número");
                Console.WriteLine("11. Adivinar el número");
                Console.WriteLine("12. Suma de tres cubos");
                Console.WriteLine("13. Números de Fibonacci");
                Console.WriteLine("14. Espiral");
                Console.WriteLine("15. Suma de dígitos al cubo");
                Console.WriteLine("16. Multiplicación rusa");
                Console.WriteLine("17. Números amistosos");
                Console.WriteLine("18. Método de Newton");
                Console.WriteLine("19. Triángulo de Pascal");
                Console.WriteLine("20. Torre y alfil");
                Console.WriteLine("21. Rango");
                Console.WriteLine("22. Valor actual neto");
                Console.WriteLine("23. Reglamento de evaluaciones");
                Console.WriteLine("24. Votaciones de la CONFECH");
                Console.WriteLine("25. Promoción con descuento");
                Console.WriteLine("26. Alzas del dólar");
                Console.WriteLine("27. Máquina de alimentos");
                Console.WriteLine("28. Intersección de circunferencias");
                Console.WriteLine("29. salir");
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
                    case 13:
                        Console.WriteLine();
                        break;
                    case 14:
                        Console.WriteLine();
                        break;
                    case 15:
                        Console.WriteLine();
                        break;
                    case 16:
                        Console.WriteLine();
                        break;
                    case 17:
                        Console.WriteLine();
                        break;
                    case 18:
                        Console.WriteLine();
                        break;
                    case 19:
                        Console.WriteLine();
                        break;
                    case 20:
                        Console.WriteLine();
                        break;
                    case 21:
                        Console.WriteLine();
                        break;
                    case 22:
                        Console.WriteLine();
                        break;
                    case 23:
                        Console.WriteLine();
                        break;
                    case 24:
                        Console.WriteLine();
                        break;
                    case 25:
                        Console.WriteLine();
                        break;
                    case 26:
                        Console.WriteLine();
                        break;
                    case 27:
                        Console.WriteLine();
                        break;
                    case 28:
                        Console.WriteLine();
                        break;
                    case 29:
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
