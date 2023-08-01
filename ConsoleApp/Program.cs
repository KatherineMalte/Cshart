// See https://aka.ms/new-console-template for more information
using System;

/*namespace ConsoleApp
{
    internal class Program*/
    //{
        string dato = "";
        double numero1 = 0.0;
        double numero2 = 0.0;
        int selection = 0;
        double resultado = 0.0;
        Console.WriteLine("Dame el primer numero ");
        dato = Console.ReadLine();
        numero1 = Convert.ToDouble(dato);

        Console.WriteLine("Dame el segundo numero ");
        dato = Console.ReadLine();
        numero2 = Convert.ToDouble(dato);

        Console.WriteLine("1. suma, 2. resta, 3. multiplicación, 4. division");
Console.WriteLine("Qué operacion desea");
dato = Console.ReadLine();
selection = Convert.ToInt32(dato);
if (selection == 1)
    resultado = numero1 + numero2;
if (selection == 2)
    resultado = numero1 - numero2;

if (selection == 3)
    resultado = numero1* numero2;

if (selection == 4)
    resultado = numero1 / numero2;

System.Console.WriteLine("el resultado es {0}", resultado); 
//} }
// if else 
//int numero = 0;
//string dato = "";

//Console.WriteLine("Dame  un numero");
//dato = Console.ReadLine();
//numero = Convert.ToInt32(dato);

//Verificar que sea par 
//if (numero % 2 == 0)
//    Console.WriteLine("El numero es par");
//else
//if (numero % 2 != 0)
//    Console.WriteLine("El numero es impar");

// and - && solo es verdadero cuando los dos son verdaderos
// not  se representa con el signo ! 
// escalera de if vara evaluar una cantidad de evaluaciones condicionales 
/*if (numero % 2 == 1)
    else if (SelectionTypes)
        else if ()*/

//switch

/*switch (seleccion)

{
    case 1: resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;

        default;

}
Console.WriteLine("El resultado es {0}");
*/

// convertir de km a millas o millas a km presentando un menu si es a km
// // pedir la cantidad de millas 
//convertir a km 
// mostrar los km 
// si es de km a millas


/*int opcion = 0;
double km = 0.0;
double millas = 0.0;
String dato="";

Console.WriteLine("1. millas a km 2. km a millas");
dato = Console.ReadLine();
opcion = Convert.ToInt32(dato);

if (opcion == 1)
{
    Console.WriteLine("Dame las millas");
    dato= Console.ReadLine();
    millas = Convert.ToDouble(dato);
    if (millas < 0)
    {
        Console.WriteLine("dar un numero positivo");
    }
    else
    {
        km = millas * 1.609;
        Console.WriteLine("{0} millas son {1} km ", millas, km);
    }
   

if (opcion == 2)
{
    Console.WriteLine("DAme los km");
    dato = Console.ReadLine();
    km = Convert.ToDouble(dato);
    if(km < 0)
    {
        millas = km / 1.609;
        Console.WriteLine("{0} km son {1} millas", km, millas);
    }
else
{
    Console.WriteLine("dar un valor  positivo");
}
}
}*/

// programa que convierte el peso en la tierra al peso a mercurio, venus o marte 
//ciclo for 

/*int cantidad = 0;
//double n = 0.0;
double sumatoria = 0.0;
double valor = 0.0;
double promedio = 0.0;
string dato = "";

Console.WriteLine("cuantos numeros quiere");
dato = Console.ReadLine();
cantidad = Convert.ToInt32(dato);
Console.WriteLine("dígite el segundo número");
dato = Console.ReadLine();
n = Convert.ToDouble(dato);

Console.WriteLine("dígite el tercer número");
dato = Console.ReadLine();
n = Convert.ToDouble(dato);

promedio = (n1 + n2 + n3) / 3.0;
*/

// ciclo for promedio

/*
for (int i = 0; i < cantidad; i = i + 1)
{
    Console.WriteLine("dígite el primer número");
    dato = Console.ReadLine();
    valor = Convert.ToDouble(dato);
    //cantidad = Convert.ToInt32(dato);

    sumatoria+= valor;
}
promedio = sumatoria / cantidad;
Console.WriteLine("El promedio es: {0}", promedio); */

/*
int n= 0;
Console.WriteLine("Ciclo que va del 3 al 17");
for (n = 3; n > 0 ; n--)
    Console.WriteLine(n);

*/
// ciclo do while 

/*
double option = 0.0;
double tipoCambio = 18.20;
double peso = 0.0;
double dolares = 0.0;
do {
    Console.WriteLine("desea convertir 1. Peso a Dolar 2. Dolares a peso 3. salir ");
    dato = Console.ReadLine();
    option
        = Convert.ToInt32(dato);

    if (option == 1)
    {
        Console.WriteLine("Cuantos pesos?");
        dato = Console.ReadLine();
        peso = Convert.ToDouble(dato);

        dolares = peso / tipoCambio;
        Console.WriteLine("Son {0} dolares", dolares);
    }
    if (option==2)
    {
        Console.WriteLine("Cuantos dolares");
        dato = Console.ReadLine();
        dolares = Convert.ToDouble(dato);
        peso= dolares * tipoCambio;
        Console.WriteLine("Son {0} pesos", peso);

    }
} while (option !=3);
Console.WriteLine("bye");
*/


//ciclo while 

/*double option = 0.0;
double dinero = 0.0;double total = 0.0;
Console.WriteLine("cuánto dinero tiene?");
 dato = Console.ReadLine();
dinero= Convert.ToInt32(dato);
while (dinero > 0 && option != 5)
{
    Console.WriteLine("1. Dulces, 2. Papas, 3. Cocolate, 4. helado, 5. salir");
    dato = Console.ReadLine();
    option
        = Convert.ToInt32(dato);
    switch (option) {
        case 1: dinero -= 3;
            total += 3;
            break;
        case 2:
            dinero -= 12;
            total += 12; break;
        case 3:
            dinero -= 7;
            total += 7;
            break;
        case 4:
            if (dinero < 25) {
                dinero -= 25;
                total += 25;
            }
            Console
                .WriteLine("no te alcanza");
            break;
    }
    Console.WriteLine("tienes {0} y has gastado {1}", dinero, total);

    
    for(n = 1; n<= 10; n++) { 
        for(m = 1; m<= 10; m++)
        {
            producto = n*m;
            Console.WriteLine("{0} x {1} = {2}", n, m, producto);
        }Console.WriteLine();
    }
*/
/*    
int n = 0;
    int m = 0;
    int producto = 0; 
    bool primo = true;
for (n=2; n < 100; n++) {
      20
primo = true;
        for (m = 2; m < n; m++) {
            if (n % m == 0)  
            primo = false;
    }

    if (primo == true) Console.Write("{0},", n);    
    Console.WriteLine();
}
*/

//arreglos
/*
double[] calif = new double[3];
    double promedio = 0.0;
double sumatoria= 0.0;
double diferencia= 0.0;
int n = 0;

for (n = 0; n < 3; n++)
{
    Console.WriteLine("Dame la calificación");
    dato = Console.ReadLine();
    calif[n] = Convert.ToDouble(dato);
     }
for(n = 0; n< 3; n++)
{
    sumatoria += calif[n];
}
promedio = sumatoria / 3;
for (n = 0; n < 3; n++)
{
    diferencia = promedio - calif[n];
    Console.WriteLine("la diferencia es {0} el promedio  es {1} y su diferncia es  ", calif[n], promedio, diferencia);
     
}
*/
 