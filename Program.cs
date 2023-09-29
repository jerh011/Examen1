// See https://aka.ms/new-console-template for more information
using Examen1;
using System.Globalization;

Metodos Ejerciciso=new Metodos();

Console.WriteLine("Ingrese el numero mas chico");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Segundo el numero mas grande");
int num2 = Convert.ToInt32(Console.ReadLine());
Ejerciciso.Primer_interativo_1(num1,num2);
Ejerciciso.Primer_interativo_2(num2,num1);

Console.WriteLine("Ingrese el numero a multiplicar");
int num3 = Convert.ToInt32(Console.ReadLine());
Ejerciciso.Multiplicacion(num3,0);
Console.WriteLine("");

