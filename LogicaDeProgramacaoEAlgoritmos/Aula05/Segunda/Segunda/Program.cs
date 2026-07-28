
using System.Runtime.CompilerServices;

const string JANELA = "Problema medidas";
Console.Title = JANELA;

//Declaração de variaveis
double a, b, c, quadrado, triangulo, trapezio;

//Entrada de dados
Console.Write("Digite a medida A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite a medida B: ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite a medida C: ");
c = double.Parse(Console.ReadLine());

//Processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();


//Saida de dados
saida();
double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

void saida()
{
    Console.WriteLine($"A area do quadrado = {quadrado:f4}\nA area do triangulo = {triangulo:f4}\n A area do trapezio = {trapezio:f4}");
}