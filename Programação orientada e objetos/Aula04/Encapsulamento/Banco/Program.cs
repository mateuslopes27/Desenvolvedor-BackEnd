using Banco;

// Declaração de variáveis
string nome;
int numero;
double saldo, quantia;
char escolha;

// Declaração da conta
ContaBancaria conta1;

// Entrada de dados
Console.Write("Entre com o numero da conta: ");
numero = int.Parse(Console.ReadLine());

Console.Write("Entre com o nome do titular: ");
nome = Console.ReadLine();

Console.Write("Deseja fazer um deposito? (s/n): ");
escolha = char.Parse(Console.ReadLine().ToLower());

if (escolha == 's')
{
    Console.Write("Entre com o valor do deposito: ");
    saldo = double.Parse(Console.ReadLine());

    conta1 = new ContaBancaria(nome, numero, saldo);
}
else
{
    conta1 = new ContaBancaria(nome, numero, 0);
}

// Exibir dados iniciais
Console.WriteLine(conta1.ExibirDados());

// Depósito
Console.Write("Entre com um valor para depósito: ");
quantia = double.Parse(Console.ReadLine());

conta1.Deposito(quantia);

Console.WriteLine("Dados Atualizados:");
Console.WriteLine(conta1.ExibirDados());

// Saque
Console.Write("Entre com um valor para saque: ");
quantia = double.Parse(Console.ReadLine());

conta1.Saque(quantia);

Console.WriteLine("Dados Atualizados:");
Console.WriteLine(conta1.ExibirDados());

Console.ReadKey();