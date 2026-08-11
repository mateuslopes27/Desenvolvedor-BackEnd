//Entrada de dados
Console.WriteLine("Base do retângulo:");
double baseRetangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Altura do retângulo:");
double alturaRetangulo = double.Parse(Console.ReadLine());

//Processamento
double area;
double perimetro;
double diagonal;

//Saída de dados
Console.WriteLine($"Área: {Area}");
Console.WriteLine($"Perímetro: {Perimetro}");
Console.WriteLine($"Diagonal: {Diagonal}");

//Funções
double Area(double b, double a)
{
    return b * a;
}

double Perimetro(double b, double a)
{
    return 2 * (b + a);
}

double Diagonal(double b, double a)
{
    return Math.Sqrt((b + b) + (a + a));
}