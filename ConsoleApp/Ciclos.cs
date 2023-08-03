using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Ciclos
    {
        public void blucles()
        {
            bool volver = false;
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
                        Double numero = 0.0;
                        Console.WriteLine("Introduce un número entero: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Tabla del: {0} ", numero);
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero + " * " + i + " = " + numero * i);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Double num = 0.0;
                        Console.WriteLine("Introduce un número entero: ");
                        num = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            Console.Write(Math.Pow(2, i) + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        double aux = 0, num1 = 0.0, num2 = 0.0;

                        Console.WriteLine("Ingresa un numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingresa otro numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());



                        for (int i = Convert.ToInt32(num1); i < num2; i++) {
                            aux += i;
                        }
                        Console.WriteLine("La suma es {0}", aux - 1);
                        Console.WriteLine();
                        break;
                    case 4:
                        /*
                        for (int i = 1; i < 11; i++) {
                        for b in range(1, 11){ 
        if a * b < 10:
            Console.WriteLine("%d  " % (a * b), end = "");
        else:
            Console.WriteLine("%d " % (a * b), end = "");

        if b == 10             }
                        }*/
                        int size = 11; // Tamaño de la matriz (11x11)
                        int[,] multiplicationTable = new int[size, size];

                        // Llenar la matriz con las tablas de multiplicar
                        for (int i = 1; i < size; i++)
                        {
                            for (int j = 1; j < size; j++)
                            {
                                multiplicationTable[i, j] = i * j;
                            }
                        }

                        // Mostrar la matriz en la consola
                        for (int i = 1; i < size; i++)
                        {
                            for (int j = 1; j < size; j++)
                            {
                                Console.Write($"{multiplicationTable[i, j],4}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("");
                        Console.WriteLine();
                        break;
                    case 5:
                        try
                        {
                            Console.Write("Ingresa un número entero: ");
                            int numero1 = int.Parse(Console.ReadLine());

                            if (numero1 <= 0)
                            {
                                Console.WriteLine("Por favor ingresa un número entero positivo.");
                            }
                            else
                            {
                                var divisores = new System.Collections.Generic.List<int>();
                                for (int i = 1; i <= numero1; i++)
                                {
                                    if (numero1 % i == 0)
                                    {
                                        divisores.Add(i);
                                    }
                                }
                                // int[] divisores = ObtenerDivisores(numero);
                                Console.WriteLine($"Los divisores de {numero1} : {string.Join(", ", divisores)}");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Por favor ingresa un número entero válido.");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        int totalMinutos = 0;

                        while (true)
                        {
                            Console.Write("Duracion tramo: ");
                            int tiempoTramo = int.Parse(Console.ReadLine());

                            if (tiempoTramo == 0)
                                break;

                            totalMinutos += tiempoTramo;
                        }

                        int horas = totalMinutos / 60;
                        int minutos = totalMinutos % 60;

                        Console.WriteLine($"El tiempo total del viaje es: {horas}:{minutos}");
                        Console.WriteLine();
                        break;
                    case 7:

                        while (!volver)
                        {
                            Console.WriteLine("Este es un programa que dibuja utilizando asteriscos ¿Qué figura desea?");
                            Console.WriteLine("1. rectángulo");
                            Console.WriteLine("2. triángulo");
                            Console.WriteLine("3. hexágono");
                            Console.WriteLine("4. volver al menú anteriror");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese la altura del rectángulo:");
                                    int altura = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese el ancho del rectángulo:");
                                    int ancho = int.Parse(Console.ReadLine());

                                    for (int i = 0; i < altura; i++)
                                    {
                                        for (int j = 0; j < ancho; j++)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine(); break;
                                case 2:
                                    Console.WriteLine("Ingrese la altura del triángulo:");
                                    int altura1 = 0;
                                     altura1 = int.Parse(Console.ReadLine());

                                    for (int i = 1; i <= altura1; i++)
                                    {
                                        // Espacios en blanco antes de los asteriscos para centrar el triángulo
                                        for (int j = 1; j <= altura1 - i; j++)
                                        {
                                            Console.Write(" ");
                                        }

                                        // Asteriscos que forman la parte del triángulo en esta fila
                                        for (int k = 1; k <= 2 * i - 1; k++)
                                        {
                                            Console.Write("*");
                                        }

                                        Console.WriteLine(); // Cambio de línea para la siguiente fila
                                    }
                                    Console.WriteLine(); break;
                                case 3:
                                    Console.WriteLine(); break;

                                case 4:
                        Console.WriteLine("Has elegido volver al anterior menú");
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 11");
                        break;
                }
            }
            Console.WriteLine();
            break;
                    case 8:
                        double sumao=0.0;
                        Console.WriteLine("Ingrese el valor de n: ");
                        int n = int.Parse(Console.ReadLine());
                   
                        for (int i = 1; i <= n; i++)
                        {
                            sumao += Math.Pow(-1 , i+1) / (2 * i - 1); 
                        }double result = 4 * sumao;

                        Console.WriteLine("El resultado es: "+result);
                        Console.WriteLine();
                        break;
                    case 9:
                       
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine("n :");
                        int nume = int.Parse(Console.ReadLine());

                        while (nume != 1)
                        {
                            if (nume % 2 == 0)
                            {
                                Console.Write(nume + ",");
                                nume = nume / 2;
                            }//fin if
                            else
                            {
                                Console.Write(nume + ",");
                                nume = (nume * 3) + 1;
                            }//fin else
                            if (nume == 1)
                            {
                                Console.WriteLine("1");
                            }
                        }
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
