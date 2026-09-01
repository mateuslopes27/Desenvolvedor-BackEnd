using System.Runtime.CompilerServices;

//Declaração
string conta;
double saldo;
int numero;
List<contaPoupanca> contaPoupancas = new();
void AbrirConta()
{
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.WriteLine("Deseja fazer deposito inicial (s/n) ? ");
    char opcion = char.Parse(Console.ReadLine().ToLower);
    if ( opcion == 's')
    {
        Console.WriteLine("Qual valor do deposito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new contaPoupanca(titular, nome, saldo, taxa);
    }
    else
    {
        conta = new ContaEmpresa(titular, numero, limite);
    }
}