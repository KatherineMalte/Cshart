using System;

namespace ConsoleApp
{
    public class Simple
    {

        public void simples() {
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
                        Console.WriteLine("Escriba su nombre");
                        string nombrePersona = "";
                        nombrePersona = Console.ReadLine();

                        Console.WriteLine("Hola Bienvenido : {0}", nombrePersona);
                        Console.WriteLine();
                        break;

                    case 2:  
                        double radio = 0.0;
                        double area = 0.0, perimetro = 0.0;
                        Console.WriteLine("Dígite el radio de un círculo"); 
                        radio = Double.Parse(Console.ReadLine());
                      
                        perimetro = 2 * Math.PI * radio;
                        area = Math.PI * Math.Pow(radio,2);
                       
                        Console.WriteLine("Su perímetro es: {0}. \nsu área es: {1}", perimetro, area);
                        Console.WriteLine();
                        break;

                    case 3:
                        double[] calif = new double[4];
                        double promedio = 0.0;
                        double sumatoria = 0.0;
                        String dato = "";
                        int n = 0;

                        for (n = 0; n < 4; n++)
                        {
                            Console.WriteLine("Dame la calificación");
                            dato = Console.ReadLine();
                            calif[n] = Convert.ToDouble(dato);
                        }
                        for (n = 0; n < 4; n++)
                        {
                            sumatoria += calif[n];
                        }
                        promedio = sumatoria / 4;
                        for (n = 0; n < 4; n++)
                        {
                            Console.WriteLine("El promedio  es {1} ", calif[n], promedio);

                        }
                        break;
                    case 4:
                        Console.WriteLine("Escribe la longitud");
                        string number = Console.ReadLine();
                        decimal dNumber = 0;

                        while (!decimal.TryParse(number, out dNumber))
                        {
                            Console.WriteLine("Escribe un número valido");
                            number = Console.ReadLine();
                        }

                        Console.WriteLine($"{number} cm = {ConvertCmToInch(dNumber)} pulgadas");

                        static decimal ConvertCmToInch(decimal cm)
                        {
                            decimal inch = cm * 0.3937M;

                            return inch;
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese un número de tres cifras.");

                        string linea= Console.ReadLine();
                        int num =0, numinv=0, u=0, d=0, c=0, aux=0;
                        num = int.Parse(linea);
                        
                        aux = num;
                        c = num / 100;
                        num = num % 100;
                        d = num / 10;
                        u = num % 10;
                        numinv = (u * 100) + (d * 10) + c;

                        Console.WriteLine(numinv);
                        Console.WriteLine();
                        break;
                    case 6:
                        int catetoA, catetoB, sumaCatetos;
                        double hipotenusa;
                        Console.WriteLine(" longitudes de cateto a");
                        string text = Console.ReadLine();
                        catetoA = int.Parse(text);
                       

                        Console.WriteLine(" longitudes de cateto b");
                        string text2 = Console.ReadLine();
                        catetoB = int.Parse(text2);

                        catetoA = catetoA * catetoA;
                        catetoB = catetoB * catetoB;
                        sumaCatetos = catetoA + catetoB;
                        hipotenusa = Math.Sqrt(sumaCatetos);

                        Console.WriteLine("La hipotenusa es: " + hipotenusa);
                        Console.WriteLine();
                        break;
                    case 7:

/*Hora actual: 11
Cantidad de horas: 43
En 43 horas, el reloj marcara las 6*/
                        int horaAct = 0;
                        int horaFut = 0;
                        int horaFruturo = 0;

                        Console.WriteLine("Hora actual");
                        string hora = Console.ReadLine();
                        horaAct = int.Parse(hora);


                        Console.WriteLine("Cantidad de horas");
                        string hora1 = Console.ReadLine();
                        horaFut = int.Parse(hora1);

                        horaFruturo = horaAct + horaFut;

                        Console.WriteLine("En {0} horas, el reloj marcara las {1}",horaAct, horaFruturo);
                        break;
                    case 8:
                        //Escriba un programa que entregue la parte decimal de un número real ingresado por el usuario.
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