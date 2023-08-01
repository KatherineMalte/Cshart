using System;

namespace ConsoleApp
{
    internal class Simple
    {

        void simples() {
            bool salir = false;
            while (!salir)
            {

                Console.WriteLine("1. saludo");
                Console.WriteLine("2. cículos");
                Console.WriteLine("3. promedio de notas");
                Console.WriteLine("4. convertir de unidades de longitud");
                Console.WriteLine("5. Número invertido");
                Console.WriteLine("6. Pitágoras");
                Console.WriteLine("7. Hora futura");
                Console.WriteLine("8. Parte decimal");
                Console.WriteLine("9. Qué nota necesito");
                Console.WriteLine("10. Huevos a la copa");
                Console.WriteLine("11. Salir");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        string nombrePersona = "";
                        string texto = "";

                        nombrePersona = Console.ReadLine();
                        Console.WriteLine("buenos días: {0}", nombrePersona);
                        System.Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        break;

                    case 3:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 4:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 5:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 6:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 7:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 8:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 9:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 10:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 11:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 10");
                        break;

                }
            }

        }


    }
}