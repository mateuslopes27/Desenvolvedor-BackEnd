//Declaração de variaveis
double largura;
double comprimento;
double area;
double valor;
double preco;

//Entrada de dados
Console.WriteLine("Digite a largura do terreno: ");
largura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do metro quadrado do terreno: ");
valor = double.Parse(Console.ReadLine());

//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//Saida de dados
Console.WriteLine($"Área do terreno: {area:n}\nPreço do terreno: R${preco:n}");