using POO2;

//Declarando variaveis
Produto p = new Produto();
int quantidade;


//Entrada de dados
Console.WriteLine();

Console.WriteLine("Preço:");
p.preco = double.Parse(Console.ReadLine());
Console.WriteLine("QUantidade:");
p.quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto:");
p.ExibirDados();

Console.WriteLine("Digite o n° de produtos a ser adicionado:");
int q = int.Parse(Console.ReadLine());
p.AdicionarProduto(q);
p.ExibirDados();

Console.WriteLine("Digite o n° de produtos a ser removido:");
int r = int.Parse(Console.ReadLine());
p.RemoverProduto(r);
Console.WriteLine("");
p.ExibirDados();