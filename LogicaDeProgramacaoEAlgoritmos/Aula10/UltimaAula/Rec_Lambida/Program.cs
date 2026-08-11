//Entrada de dados
Console.WriteLine("Base do retângulo:");
double baseRetangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Altura do retângulo:");
double alturaRetangulo = double.Parse(Console.ReadLine());

//Processamento
Func<double, double, double> calc_area = (b, a) => baseRetangulo * alturaRetangulo;
Func<double, double, double> calc_perimetro = (b, a) => 2 * (baseRetangulo + alturaRetangulo);
Func<double, double, double> calc_diagonal = (b, a) => Math.Sqrt((baseRetangulo * baseRetangulo) + (alturaRetangulo * alturaRetangulo));

double area = calc_area(baseRetangulo, alturaRetangulo);
double perimetro = calc_perimetro(baseRetangulo, alturaRetangulo);
double diagonal = calc_diagonal(baseRetangulo, alturaRetangulo);

//Saída de dados
Console.WriteLine($"Área: {area.ToString()}");
Console.WriteLine($"Perímetro: {perimetro.ToString()}");
Console.WriteLine($"Diagonal: {diagonal.ToString()}");

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
    return Math.Sqrt((b * b) + (a * a));
}