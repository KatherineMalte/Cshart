using System;
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
            bool volver = false;
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
                        int numero = 0;
                        string dato = "";
                        Console.WriteLine("Dame  un numero");
                        dato = Console.ReadLine();
                        numero = Convert.ToInt32(dato);
                        if (numero % 2 == 0)
                            Console.WriteLine("El numero es par");
                        else
                        if (numero % 2 != 0)
                            Console.WriteLine("El numero es impar");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        int dividendo = 0;
                        string dato1 = "";
                        int division = 0;
                        Console.WriteLine("Escriba el dividendo: ");
                        dato1 = Console.ReadLine();
                        dividendo = Convert.ToInt32(dato1);
                        int divisor = 0;
                        string dato2 = "";
                        Console.WriteLine("Escriba el divisor: ");
                        dato2 = Console.ReadLine();
                        divisor = Convert.ToInt32(dato2);
                        int res = dividendo % divisor;
                        division = dividendo / divisor;
                        if (dividendo % divisor == 0)
                        {

                            Console.WriteLine("La división es exacta. Cociente: {0} , Resto:{1}", divisor, res);
                        }
                        else
                        {
                            Console.WriteLine("La división no es exacta. Cociente: {0}, Resto:{1}", division, res);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        string palabra2 = "";
                        string palabra1 = "";
                        int conteo1 = 0, conteo2 = 0, diferencia = 0;
                        Console.WriteLine("Palabra 1:");
                        palabra1 = Console.ReadLine();
                        Console.WriteLine("Palabra 2:");
                        palabra2 = Console.ReadLine();

                        conteo1 = palabra1.Length;
                        conteo2 = palabra2.Length;
                        diferencia = Math.Abs(conteo1 - conteo2);

                        if (conteo1 > conteo2)
                        {
                            Console.WriteLine("\nLa palabra {0}  tiene {1} letras más que {2}\n", palabra1, diferencia, palabra2);
                        }
                        if (conteo1 < conteo2)
                        {
                            Console.WriteLine("\nLa palabra {0}  tiene {1} letras más que {2}\n", palabra2, diferencia, palabra1);
                        }
                        if (conteo1 == conteo2)
                        {
                            Console.WriteLine("\nLas palabras tienen la misma longitud\n");
                        }
                        Console.WriteLine("La diferencia es de {0} letra(s)\n", diferencia);
                        Console.WriteLine();
                        break;
                    case 5:
                
                        while (!volver)
                        {
                            Console.WriteLine("Este es un programa que ordena números de menor a mayor ¿con cuántos numeros desea ordenar?");
                            Console.WriteLine("1. dos números");
                            Console.WriteLine("2. tres números");
                            Console.WriteLine("3. cuatro números");
                            Console.WriteLine("4. volver al menú anteriror");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1) {
                                case 1:
                                    int a = 0;
                                    int b = 0;
                                    string dato3 = "";
                                    string dato4 = "";

                                    Console.WriteLine("ingrese el primer numero:");
                                    dato3 = Console.ReadLine();
                                    a = Convert.ToInt32(dato3);

                                    Console.WriteLine("ingrese el segundo numero:");
                                    dato4 = Console.ReadLine();
                                    b = Convert.ToInt32(dato4);
                                    if (a > b)
                                    {
                                        Console.WriteLine(" " + b + " " + a);
                                    }
                                    else
                                    {
                                        Console.WriteLine(" " + a + " " + b);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    int a1 = 0;
                                    int b2 = 0;
                                    int c3 = 0;
                                    string dato5 = "";
                                    string dato6 = "";
                                    string dato7 = "";

                                    Console.WriteLine("ingrese el primer numero:");
                                    dato5 = Console.ReadLine();
                                    a1 = Convert.ToInt32(dato5);

                                    Console.WriteLine("ingrese el segundo numero:");
                                    dato6 = Console.ReadLine();
                                    b2 = Convert.ToInt32(dato6);

                                    Console.WriteLine("ingrese el tercer numero:");
                                    dato7 = Console.ReadLine();
                                    c3 = Convert.ToInt32(dato7);

                                    if (a1 > b2 && a1 > c3)
                                    {
                                        if(b2 > c3) {
                                            Console.WriteLine(" " + c3 + " " + b2 + " " + a1);
                                        }else { Console.WriteLine(" " + b2 + " " + c3 + " " + a1); }
                                    }
                                    if (b2  > a1 && b2 > c3)
                                    {
                                        if (c3 > a1) { 
                                        Console.WriteLine(" " + a1 + " " + c3+" " + b2);
                                    }
                                    else { Console.WriteLine(" " + c3 + " " + a1 + " " + b2); }
                                        

                                    }
                                    if (c3 > b2 && c3 >a1 )
                                    {
                                        if (b2 > a1) { 
                                            Console.WriteLine(" " + a1 + " " + b2 + " " + c3);
                                    }
                                    else { Console.WriteLine(" " + b2 + " " + a1 + " " + c3); }
                                    }
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    int a2 = 0;
                                    int b3 = 0;
                                    int c4 = 0;
                                    int d5 = 0;
                                    string dato8 = "";
                                    string dato9 = "";
                                    string dato10 = "";
                                    string dato11 = "";

                                    Console.WriteLine("ingrese el primer numero:");
                                    dato8 = Console.ReadLine();
                                    a2 = Convert.ToInt32(dato8);

                                    Console.WriteLine("ingrese el segundo numero:");
                                    dato9 = Console.ReadLine();
                                    b3 = Convert.ToInt32(dato9);

                                    Console.WriteLine("ingrese el tercer numero:");
                                    dato10 = Console.ReadLine();
                                    c4 = Convert.ToInt32(dato10);

                                    Console.WriteLine("ingrese el cuarto numero:");
                                    dato11 = Console.ReadLine();
                                    d5 = Convert.ToInt32(dato11);
                
                

                                    if (a2 > b3 && a2 > c4 && a2 > d5)
                                    {
                                        if (b3 > c4 && b3 > a2 && b3>d5)
                                        {
                                           if(c4 > d5)
                                            {
                                            Console.WriteLine(" " + d5 + " " + c4 + " " + b3 + " " + a2);
                                            }  
                                        }
                                        else { Console.WriteLine(" " + c4 + " " + d5 + " " + b3 + " " + a2); }
                                     
                                    }
                                    
                                 
                                        if (b3 > a2 && b3 > c4 && b3 > d5)
                                    {
                                        if (c4 > a2)
                                        {
                                            Console.WriteLine(" " + a2 + " " + c4 + " " + b3);
                                        }
                                        else { Console.WriteLine(" " + c4 + " " + a2 + " " + b3); }


                                    }
                                    if (c4 > b3 && c4 > a2 && c4> d5 )
                                    {
                                        if (b3 > a2)
                                        {
                                            Console.WriteLine(" " + a2 + " " + b3 + " " + c4);
                                        }
                                        else { Console.WriteLine(" " + b3 + " " + a2 + " " + c4); }
                                    }
                                   

                
                                    Console.WriteLine();
                                    break;
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
