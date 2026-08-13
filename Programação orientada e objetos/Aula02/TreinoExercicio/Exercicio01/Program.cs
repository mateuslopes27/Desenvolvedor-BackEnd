using Exercicio01;

//Entrada de dados
Console.Write("Digite a altura: ");
double altura = double.Parse(Console.ReadLine());
Console.Write("Digite a largura: ");
double largura = double.Parse(Console.ReadLine());

_01 retangulo = new _01(altura, largura);

//Saída de dados
Console.WriteLine($"Os valores digitados foram\n\n Altura: {retangulo.altura:f2}\n Largura: {retangulo.largura:f2}\n");
Console.WriteLine($"Área: {retangulo.area:f2}");
Console.WriteLine($"Perímetro: {retangulo.perimetro:f2}");
Console.WriteLine($"Diagonal: {retangulo.diagonal:f2}");