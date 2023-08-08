using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DiseñoAlgoritmos
    {

        public void algoritmo()
        {
            bool volver = false;
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
                        Console.WriteLine("Elegiste la opción 1.  Dígitos");
                        Console.Write("Ingrese un número entero: ");
                        int numero = int.Parse(Console.ReadLine());
                        int cociente = 0, divisor = 1, contador=0;
                        // int cantidadDigitos = ContarDigitos(numero);
                        while (cociente != 1)
                        {
                            contador++;
                            divisor = divisor * 10;
                            cociente = numero / divisor;
                            if (cociente == 1)
                            {
                                Console.WriteLine(" "+(numero)+" tiene: " + (contador + 1) + " digitos");
                            }
                            if (cociente < 1)
                            {
                                Console.WriteLine(" " + (numero) + " tiene: " + contador + " digitos");
                                cociente = 1;
                            }
                            if (numero < 10)
                            {
                                Console.WriteLine("Solo tiene un digito");
                                cociente = 1;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste la opción 2.  Dígito verificador");
                        Console.Write("Ingrese su rol UTFSM sin guion ni dígito verificador: ");
                        int rol = Convert.ToInt32(Console.ReadLine());
                        string rolCopia = rol.ToString();
                        string invertido = "";

                        for (int i = rolCopia.Length - 1; i >= 0; i--)
                        {
                            invertido += rolCopia[i];
                        }

                        int suma = 0;
                        int multiplicador = 2;

                        for (int i = 0; i < rolCopia.Length; i++)
                        {
                            if (multiplicador == 8)
                            {
                                multiplicador = 2;
                            }
                            suma += Convert.ToInt32(invertido[i]) * multiplicador;
                            multiplicador++;
                        }

                        int modulo = suma % 11;
                        int digitoVerificador = 11 - modulo;
                        Console.WriteLine("El dígito verificador del rol " + rol + " es " + digitoVerificador + ". Por lo tanto, el rol es: " + rolCopia + "-" + digitoVerificador);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Elegiste la opción 3.  Ecuación primer grado");
                        Console.Write("Ingrese a: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese b: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        if (a == 0 && b != 0)
                        {
                            Console.WriteLine("Sin solucion");
                        }
                        else if (a == 0 && b == 0)
                        {
                            Console.WriteLine("No hay solucion unica.");
                        }
                        else
                        {
                            Console.WriteLine("Solucion unica: " + (-b / a));
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Elegiste la opción 4.  Caballo de ajedrez");
                        Console.WriteLine("Elegiste la opción 4. ");
                        Console.WriteLine("Ingrese coordenadas del caballo.");

                        Console.Write("Fila: ");
                        int fila = int.Parse(Console.ReadLine());

                        Console.Write("Columna: ");
                        int columna = int.Parse(Console.ReadLine());

                        if (1 <= fila && fila <= 8 && 1 <= columna && columna <= 8)
                        {
                            Console.WriteLine($"El caballo puede saltar de {fila}, {columna} a: ");
                            for (int i = -2; i <= 2; i++)
                            {
                                for (int j = -2; j <= 2; j++)
                                {
                                    int x = i + fila;
                                    int y = j + columna;
                                    if (1 <= x && x <= 8 && 1 <= y && y <= 8 && i != 0 && j != 0 && Math.Abs(i) != Math.Abs(j))
                                    {
                                        Console.WriteLine($"{x}, {y}");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posicion invalida.");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Elegiste la opción 5.  Media armónica");
                        Console.Write("Cuantos numeros: ");
                        int n = int.Parse(Console.ReadLine());

                        double denominador = 0.0;
                        for (int i = 1; i <= n; i++)
                        {
                            Console.Write("n" + i + " = ");
                            int n_i = int.Parse(Console.ReadLine());
                            denominador += 1.0 / n_i;
                        }

                        Console.WriteLine("H = " + n / denominador);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Elegiste la opción 6.  Números palíndromos");
                        Console.Write("Ingrese un número: ");
                        string num = Console.ReadLine();

                        string num_inv = "";
                        for (int i = num.Length - 1; i >= 0; i--)
                        {
                            num_inv += num[i];
                        }

                        if (num == num_inv)
                        {
                            Console.WriteLine(num + " es palíndromo");
                        }
                        else
                        {
                            Console.WriteLine(num + " no es palíndromo");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Elegiste la opción 7.  Palabras palíndromas");
                        while (!volver)
                        {
                            Console.WriteLine("Este es un programa que ordena números de menor a mayor ¿con cuántos numeros desea ordenar?");
                            Console.WriteLine("1. entrada una palabra");
                            Console.WriteLine("2. oraciones palíndromas");
                            Console.WriteLine("3. volver al menú anteriror");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1)
                            {
                                case 1:
                                    Console.Write("Ingrese palabra: ");
                                    string palabra = Console.ReadLine();

                                    string palabra_inv = "";
                                    for (int i = palabra.Length - 1; i >= 0; i--)
                                    {
                                        palabra_inv += palabra[i];
                                    }

                                    if (palabra == palabra_inv)
                                    {
                                        Console.WriteLine("Es palindromo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No es palindromo");
                                    }
                                    Console.WriteLine();
                            break;
                                case 2:
                                    Console.Write("Ingrese oración: ");
                                    string oracion = Console.ReadLine();
                                    string oracionSinEspacios = "";

                                    foreach (char c in oracion)
                                    {
                                        if (c != ' ')
                                        {
                                            oracionSinEspacios += c;
                                        }
                                    }

                                    string oracionInv = "";
                                    for (int i = oracionSinEspacios.Length - 1; i >= 0; i--)
                                    {
                                        oracionInv += oracionSinEspacios[i];
                                    }

                                    if (oracionSinEspacios == oracionInv)
                                    {
                                        Console.WriteLine("Es palíndromo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No es palíndromo");
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
                    case 8:
                        Console.WriteLine("Elegiste la opción 8.  Cachipún");
                        int puntos_a = 0;
                        int puntos_b = 0;
                        string A = "";
                        string B = "";

                        while (puntos_a < 3 && puntos_b < 3)
                        {
                            Console.Write("Cachipun A: ");
                            A = Console.ReadLine();
                            Console.Write("Cachipun B: ");
                            B = Console.ReadLine();

                            if ((A == "tijera" && B == "papel") || (A == "piedra" && B == "tijera") || (A == "papel" && B == "piedra"))
                            {
                                puntos_a++;
                                Console.WriteLine("A: " + puntos_a + " - B: " + puntos_b);
                            }
                            else if ((A == "piedra" && B == "papel") || (A == "papel" && B == "tijera") || (A == "tijera" && B == "piedra"))
                            {
                                puntos_b++;
                                Console.WriteLine("A: " + puntos_a + " - B: " + puntos_b);
                            }
                            else if (A == B)
                            {
                                Console.WriteLine("A: " + puntos_a + " - B: " + puntos_b);
                            }
                            else
                            {
                                Console.WriteLine("Opcion no correcta");
                            }
                        }

                        if (puntos_a == 3)
                        {
                            Console.WriteLine("A es el ganador");
                        }
                        else if (puntos_b == 3)
                        {
                            Console.WriteLine("B es el ganador");
                        }
                        Console.WriteLine();
                        break;
                    case 9:
                        while (!volver)
                        {
                            Console.WriteLine("Este es un programa que ordena números de menor a mayor ¿con cuántos numeros desea ordenar?");
                            Console.WriteLine("1.primo o compuesto");
                            Console.WriteLine("2. números primos de n");
                            Console.WriteLine("3. números primos menores que m");
                            Console.WriteLine("4. contar números primos menores que m");
                            Console.WriteLine("5. factores primos de n");
                            Console.WriteLine("6. número par n con todas las maneras en que puede ser escrito como una suma de dos primos");
                            Console.WriteLine("7. respondan preguntas");
                            Console.WriteLine("8. volver al menú anteriror");
                            int opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    Console.WriteLine("Elegiste la opción 9.  Números primos");
                                    Console.Write("Ingrese un numero: ");
                                    int n2 = int.Parse(Console.ReadLine());

                                    bool esPrimo = true;

                                    for (int i = 2; i < n2; i++)
                                    {
                                        if (n2 % i == 0)
                                        {
                                            esPrimo = false;
                                            break;
                                        }
                                    }

                                    if (esPrimo)
                                    {
                                        Console.WriteLine($"{n2} es primo");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{n2} es compuesto");
                                    }
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    Console.Write("Ingrese un numero: ");
                                    int cantidad = int.Parse(Console.ReadLine());

                                    int contadors = 1;
                                    int n3 = 2;
                                    int primo = 0;

                                    while (contadors <= cantidad)
                                    {
                                        bool isPrimo = true;

                                        for (int i = 2; i < n3; i++)
                                        {
                                            if (n3 % i == 0)
                                            {
                                                esPrimo = false;
                                                break;
                                            }
                                        }

                                        if (isPrimo)
                                        {
                                            primo = n3;
                                            contadors++;
                                        }
                                        n3++;
                                    }

                                    Console.WriteLine(primo);
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    Console.Write("Primos menores que: ");
                                    int cantida = int.Parse(Console.ReadLine());

                                    for (int i = 2; i < cantida; i++)
                                    {
                                        bool sPrimo = true;

                                        for (int j = 2; j < i; j++)
                                        {
                                            if (i % j == 0)
                                            {
                                                sPrimo = false;
                                                break;
                                            }
                                        }

                                        if (sPrimo)
                                        {
                                            Console.WriteLine(i);
                                        }
                                        Console.WriteLine();
                                    }
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
                                   // ¿Cuántos primos menores que diez mil terminan en 7 ?
//¿Cuál es la suma de los cuadrados de los números primos entre 1 y 1000 ? (Respuesta: 49.345.379).
//¿Cuál es el producto de todos los números primos menores que 100 que tienen algún dígito 7 ? (Respuesta: 7 × 17 × 37 × 47 × 67 × 71 × 73 × 79 × 97 = 550.682.633.299.463).
                                    Console.WriteLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Has elegido volver al anterior menú");
                                    volver = true;
                                    break;
                                default:
                                    Console.WriteLine("Elige una opcion entre 1 y 7");
                                    break;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine("Elegiste la opción 10. El mejor número");
                       
                        Console.WriteLine();
                        break;
                    case 11:
                        Console.WriteLine("Elegiste la opción 11. Adivinar el número");
                        /* Random random = new Random();
                         int n9 = random.Next(101);

                         int contadr = 1;
                         int intento = 9999;

                         Console.WriteLine("Adivine el número");

                         while (n9 != intento)
                         {
                             Console.Write("Intento " + contadr + ": ");
                             intento = int.Parse(Console.ReadLine());

                             if (intento < n9)
                             {
                                 Console.WriteLine("Es mayor que " + intento);
                                 contadr++;
                             }
                             else if (intento > n9)
                             {
                                 Console.WriteLine("Es menor que " + intento);
                                 contadr++;
                             }
                             else
                             {
                                 Console.WriteLine("Correcto. Adivinaste en " + contadr + " intentos. Era el " + intento);
                             }
                         }*/
                        string caracter = "";
                        int contdor = 1;
                        int techo = 100;
                        int piso = 0;
                        Random random = new Random();
                        int n88 = random.Next(101);

                        while (caracter != "=")
                        {
                            Console.WriteLine("Intento " + contdor + ": " + n88);
                            Console.Write(">, < o =?: ");
                            caracter = Console.ReadLine();

                            if (caracter == ">")
                            {
                                piso = n88;
                                n88 = (n88 + techo) / 2;
                                contdor++;
                            }
                            else if (caracter == "<")
                            {
                                techo = n88;
                                n88 = (n88 + piso) / 2;
                                contdor++;
                            }
                        }

                        Console.WriteLine("Adivine en " + contdor + " intentos B-)");
                
                Console.WriteLine();
                        break;
                    case 12:
                        Console.WriteLine("Elegiste la opción 12. Suma de tres cubos");
                        List<int> lista = new List<int>();
                        for (int i = 0; i < 100; i++) // Primer número de la suma
                        {
                            for (int j = 0; j < 100; j++) // Segundo número de la suma
                            {
                                for (int ke = 0; ke < 100; ke++) // Tercer número de la suma
                                {
                                    for (int l = 1; l <= 2; l++) // Signo del primer número
                                    {
                                        for (int w = 1; w <= 2; w++) // Signo del segundo número
                                        {
                                            for (int o = 1; o <= 2; o++) // Signo del tercer número
                                            {
                                                int num1 = (int)Math.Pow(-1, l) * i;
                                                int num2 = (int)Math.Pow(-1, w) * j;
                                                int num3 = (int)Math.Pow(-1, o) * ke;

                                                if (Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3) == 100)
                                                {
                                                    if (!lista.Contains(num1) && !lista.Contains(num2) && !lista.Contains(num3))
                                                    {
                                                        Console.WriteLine($"{num1} {num2} {num3}");
                                                        lista.Add(num1);
                                                        lista.Add(num2);
                                                        lista.Add(num3);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 13:
                        Console.WriteLine("Elegiste la opción 13. Números de Fibonacci");
                        while (!volver)
                        {
                            Console.WriteLine("Este es un programa que ordena Números de Fibonacci segun lo ingresado");
                            Console.WriteLine("1. ésimo número de Fibonacci");
                            Console.WriteLine("2. es o no un número de Fibonacci");
                            Console.WriteLine("3. primeros números de Fibonacci");
                            Console.WriteLine("4. volver al menú anteriror");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1)
                            {
                                case 1:
                                    Console.Write("Ingrese n: ");
                        int nu = int.Parse(Console.ReadLine());

                        int xx = 0; // F_0
                        int yy = 1; // F_1
                        int zz = 1; // F_2

                        for (int io = 0; io < nu; io++)
                        {
                            yy = zz;
                            zz = xx + yy;
                            xx = yy;
                        }

                        Console.WriteLine("F" + nu + " = " + yy);
                                    break;
                        case 2:

                        Console.Write("Ingrese un numero: ");
                        int n1 = int.Parse(Console.ReadLine());

                        int i = 1;
                        int f_0 = 0; // F_0
                        int F_1 = 1; // F_1
                        int F_2 = 1; // F_2
                        bool es_fibonacci = false;

                        while (i != n1)
                        {
                                        F_1 = F_2;
                                        F_2 = f_0 + F_1;
                            f_0 = F_1;
                            i++;

                            if (F_1 == n1)
                            {
                                es_fibonacci = true;
                                break;
                            }
                        }

                        if (es_fibonacci == true)
                        {
                            Console.WriteLine(n1 + " es un numero Fibonacci");
                        }
                        else
                        {
                            Console.WriteLine(n1 + " no es un numero Fibonacci");
                        } break;
                                case 3:

                        Console.Write("Ingrese m: ");
                        int n6 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Los " + n6 + " primeros numeros de Fibonacci son: ");
                        Console.Write(0);

                        int i6 = 1;
                        int x6 = 0;  // F_0
                        int y6 = 1;  // F_1
                        int z6 = 1;  // F_2

                        while (i6 != n6)
                        {
                        
                            y6 = z6;
                            z6 = x6 + y6;
                            x6 = y6;
                            i6++;
                            Console.Write(" " + y6);
                        }
                                    break;
                                case 4:
                                    Console.WriteLine("Has elegido volver al anterior menú");
                                    volver = true;
                                    break;
                                default:
                                    Console.WriteLine("Elige una opcion entre 1 y 3");
                                    break;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 14:
                        Console.WriteLine("Elegiste la opción 14. Espiral");
                        Console.WriteLine();
                        break;
                    case 15:
                        Console.WriteLine("Elegiste la opción 15. Suma de dígitos al cubo");
                        for (int i = 150; i < 411; i++)
                        {
                            string v = i.ToString();
                            int centena = int.Parse(v[0].ToString());
                            int decena = int.Parse(v[1].ToString());
                            int unidad = int.Parse(v[2].ToString());
                            if (Math.Pow(centena, 3) + Math.Pow(decena, 3) + Math.Pow(unidad, 3) == i)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 16:
                        Console.WriteLine("Elegiste la opción 16. Multiplicación rusa");
                        int m = int.Parse(Console.ReadLine());
                        int nn = int.Parse(Console.ReadLine());

                        int sum = 0;

                        while (m >= 1)
                        {
                            if (m % 2 != 0)
                            {
                                sum += nn;
                            }
                            m /= 2;
                            nn *= 2;
                        }

                        Console.WriteLine("Resultado: " + sum);
                        Console.WriteLine();
                        break;
                    case 17:
                        Console.WriteLine("Elegiste la opción 17. Números amistosos");
                        for (int i = 1000; i < 1500; i++)
                        {
                            for (int j = 1000; j < 1500; j++)
                            {
                                int suma_div_i = 0;
                                for (int k1 = 1; k1 < i; k1++)  // divisores de i
                                {
                                    if (i % k1 == 0)
                                    {
                                        suma_div_i += k1;
                                    }
                                }

                                int suma_div_j = 0;
                                for (int l = 1; l < j; l++)  // divisores de j
                                {
                                    if (j % l == 0)
                                    {
                                        suma_div_j += l;
                                    }
                                }

                                if (suma_div_i == j && suma_div_j == i)
                                {
                                    Console.WriteLine(i + " " + j);
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 18:
/*
                while (!volver) 
                {
                            Console.WriteLine("Este es un programa de metodo newton");
                            Console.WriteLine("1. dos números");
                            Console.WriteLine("2. tres números");
                            Console.WriteLine("4. volver al menú anteriror");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1)
                            {
                                case 1:
                        Console.WriteLine("Elegiste la opción 18. Método de Newton");
                        Console.Write("Ingrese numero: ");
                        double x1 = Convert.ToDouble(Console.ReadLine());

                        double y1 = 1.0;
                        double cuociente = x1 / y1;
                        double promedio = (y1 + cuociente) / 2;

                        while (Math.Abs(x1 - (y1 * y1)) > 0.0001)
                        {
                            y1 = promedio;
                            cuociente = x1 / y1;
                            promedio = (y1 + cuociente) / 2;
                        }

                        Console.WriteLine(y1);
                                    Console.WriteLine();
                                    break;

                        case 2:
                        Console.Write("Ingrese x: ");
                        double x = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Cifras decimales: ");
                        int s = Convert.ToInt32(Console.ReadLine());

                        double  k= x / 2; // estimacion

                        int dec_1 = 1;
                        int dec_2 = 2;

                        while (dec_2 != dec_1)
                        {
                            double c = x / k;
                            dec_1 = (int)(Math.Abs(k - (int)k) * Math.Pow(10, s));
                            k = (c + k) / 2;
                            dec_2 = (int)(Math.Abs(k - (int)k) * Math.Pow(10, s));
                        }

                        Console.WriteLine("La estimacion de raiz de " + x + " es: " + k);
                        }
                            Console.WriteLine();
                            break;
                    case 3:
                        Console.WriteLine("Has elegido volver al anterior menú");
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 11");
                        break;
                }
            }
*/
            Console.WriteLine();   
                        break;
                    case 19:
                        Console.WriteLine("Elegiste la opción 19. Triángulo de Pascal");
                        Console.WriteLine();
                        break;
                    case 20:
                        Console.WriteLine("Elegiste la opción 20. Torre y alfil");
                        Console.WriteLine();
                        break;
                    case 21:
                        Console.WriteLine("Elegiste la opción 21. Rango");
                        Console.WriteLine();
                        break;
                    case 22:
                        Console.WriteLine("Elegiste la opción 22. Valor actual neto");
                        Console.WriteLine();
                        break;
                    case 23:
                        Console.WriteLine("Elegiste la opción 23. Reglamento de evaluaciones");
                        Console.WriteLine();
                        break;
                    case 24:
                        Console.WriteLine("Elegiste la opción 24. Votaciones de la CONFECH");
                        Console.WriteLine();
                        break;
                    case 25:
                        Console.WriteLine("Elegiste la opción 25. Promoción con descuento");
                        Console.WriteLine();
                        break;
                    case 26:
                        Console.WriteLine("Elegiste la opción 26. Alzas del dólar");
                        Console.WriteLine();
                        break;
                    case 27:
                        Console.WriteLine("Elegiste la opción 27. Máquina de alimentos");
                        Console.WriteLine();
                        break;
                    case 28:
                        Console.WriteLine("Elegiste la opción 28. Intersección de circunferencias");
                        Console.WriteLine();
                        break;
                    case 29:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 28");
                        break;
                }
            }
        }
    }
}
