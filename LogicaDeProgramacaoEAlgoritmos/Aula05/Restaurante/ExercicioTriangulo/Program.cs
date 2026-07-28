//Entrada de dados + Declaração das variaveis
double a, b, c, medida1, medida2, medida3, perimetro, area, altura;

try
{

    Console.Write("Escreva o valor do lado A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor do lado B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor do lado C: ");
    c = double.Parse(Console.ReadLine());
    //Processando dados
    medida1 = b + c;
    medida2 = a + c;
    medida3 = b + a;
    perimetro = a + b + c;
    altura = (2 * a) / b;
    area = (c * altura) / 2;

    //Saida de dados
    if (medida1 < a || medida2 < b || medida3 < c)
    {
        Console.WriteLine($"O perimetro é de: {perimetro:f4}");
    }
    else
    {
        Console.WriteLine($"A área do triangulo é de: {area:f4}");
    }


}
catch
{
    Console.WriteLine("Digite um numero válido!");
}