using System.Security.Principal;
using Triangulo_Com_Poo;
Triangulo x = new();
Triangulo y = new();

//Entrada de dados
Console.WriteLine("dados do triangulo X:");
Console.WriteLine("Lado A:");
x.a = double.Parse(Console.ReadLine());
Console.WriteLine("Lado B:");
x.b = double.Parse(Console.ReadLine());
Console.WriteLine("Lado C:");
x.c = double.Parse(Console.ReadLine());

Console.WriteLine("dados do triangulo Y:");
Console.WriteLine("Lado A:");
y.a = double.Parse(Console.ReadLine());
Console.WriteLine("Lado B:");
y.b = double.Parse(Console.ReadLine());
Console.WriteLine("Lado C:");
y.c = double.Parse(Console.ReadLine());

//Processamento de dados
Console.WriteLine($"Area do triangulo X: {x.Area():f2}");
Console.WriteLine($"Area do triangulo Y: {y.Area():f2}");