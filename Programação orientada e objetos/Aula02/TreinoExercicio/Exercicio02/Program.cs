using Exercicio02;

//Entrada de dados
Console.Write("Digite o nome: ");
string nome = Console.ReadLine();
Console.Write("Digite o salário bruto: ");
double salariob = double.Parse(Console.ReadLine());
Console.Write("Digite o imposto: ");
double imposto = double.Parse(Console.ReadLine());

Exerdois funcionario = new Exerdois(nome, salariob, imposto);

//Saída de dados
Console.WriteLine($"Os valores digitados foram\n\n Nome: {funcionario.nome}\n Salário Bruto: {funcionario.salariob:f2}\n Imposto: {funcionario.imposto:f2}\n\n Salário Líquido: {funcionario.salariol:f2}");

//Entrada de dados para aumento de salário
Console.Write("Digite a porcentagem de aumento: ");
double porcentagem1 = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagem1);
Console.WriteLine($"Salario do funcionario foi aumentado em {porcentagem1}%");
Console.WriteLine($"Dados do funcionario atualizados\n       Nome do Funcionário: {funcionario.nome}\n       Salário liquído: {funcionario.salariol:f2}");