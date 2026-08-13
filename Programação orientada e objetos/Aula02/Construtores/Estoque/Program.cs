using Estoque;

//Campos
string nome;
int quantidade, tquantidade, qtd;
double preco;

//Entrada de dados
Console.WriteLine("Digite o nome do produto: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a quantidade do produto: ");
tquantidade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço do produto: ");
preco = double.Parse(Console.ReadLine());

produto objeto = new produto(nome, tquantidade, preco);
produto objeto2 = new produto(nome, tquantidade, preco);
produto p = new produto();

Console.WriteLine();
Console.ReadKey();