//Criação das variáveis
using System.Security.AccessControl;
double basee;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.Write("Digite a medida da base: ");
basee = double.Parse(Console.ReadLine());
Console.Write("Digite a medida da altura: ");
altura = double.Parse(Console.ReadLine());

//Processamento dos dados
area = basee * altura;
perimetro = (basee*2) + (altura*2);
diagonal = Math.Sqrt(Math.Pow(basee, 2) + Math.Pow(altura, 2));

//Saída de dados
Console.WriteLine($"Área do retangulo: {area:f4}\nPerimetro do retangulo: {perimetro:f4}\nDiadonal do triangulo: {diagonal:f4}");
