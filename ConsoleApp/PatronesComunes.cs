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
                        Console.Write("Ingrese un número: ");
                        int n0 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Números no múltiplos de 3 ni de 7 menores o iguales a " + n0 + ":");

                        for (int i = 1; i <= n0; i++)
                        {
                            if (i % 3 != 0 && i % 7 != 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Ingrese un número: ");
                        String dato1 = Console.ReadLine();

                        int num1 = int.Parse(dato1);
                        int suma = 0;
                        dato1 = Convert.ToString(suma);
                        int n = 0;
                        for (int i = 1; i <= num1; i++)
                        {
                            suma = suma + i;
                            n = i * (i + 1) / 2;
                        }
                        if (suma != n) { Console.WriteLine("no son iguales"); }
                        else
                        {
                            string resultado = "El resultado de la suma de: " + suma.ToString();
                            Console.WriteLine(n);
                            Console.WriteLine(resultado);
                            Console.WriteLine("son iguales");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad de números: ");
                        int n1 = int.Parse(Console.ReadLine());

                        int mayor = int.MinValue; // Inicializamos la variable "mayor" con el valor mínimo posible

                        for (int i = 0; i < n1; i++)
                        {
                            Console.Write($"Ingrese el número {i + 1}: ");
                            int numero = int.Parse(Console.ReadLine());

                            if (numero > mayor)
                            {
                                mayor = numero;
                            }
                        }
                        Console.WriteLine($"El número mayor es: {mayor}");
                        Console.WriteLine();
                        break;
                    case 4:
                        //productos especiales
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    case 6:
                        int positivos = 0;
                        int negativos = 0;

                        Console.WriteLine("Ingrese varios valores enteros (ingrese 0 para terminar):");

                        while (true)
                        {
                            Console.Write("Ingrese un valor: ");
                            int numero = int.Parse(Console.ReadLine());

                            if (numero == 0)
                                break;

                            if (numero > 0)
                                positivos++;
                            else
                                negativos++;
                        }
                        Console.Write("positivos: ");
                        for (int i = 0; i < positivos; i++)
                        {

                            Console.Write("*");

                        }
                        Console.WriteLine();
                        Console.Write("negativos: ");
                        for (int j = 0; j < negativos; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.Write("Ingrese la cantidad de palabras: ");
                        int nmr = int.Parse(Console.ReadLine());

                        string palabraMasLarga = "";
                        string palabraMasCorta = null;

                        for (int i = 0; i < nmr; i++)
                        {
                            Console.Write($"Ingrese la palabra {i + 1}: ");
                            string palabra = Console.ReadLine();

                            if (palabraMasCorta == null || palabra.Length < palabraMasCorta.Length)
                            {
                                palabraMasCorta = palabra;
                            }

                            if (palabra.Length > palabraMasLarga.Length)
                            {
                                palabraMasLarga = palabra;
                            }
                        }

                        Console.WriteLine($"Palabra más larga: {palabraMasLarga}");
                        Console.WriteLine($"Palabra más corta: {palabraMasCorta}");
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine("Combinaciones posibles al lanzar dos dados de 6 caras:");

                        for (int dado1 = 1; dado1 <= 6; dado1++)
                        {
                            for (int dado2 = 1; dado2 <= 6; dado2++)
                            {
                                Console.WriteLine($" 1: {dado1}    2: {dado2}");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 10:
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
