using Banco.CLasses.Contextos;
using Microsoft.EntityFrameworkCore;

ContaContext context = new ContaContext();
context.Database.EnsureCreated();

void CadastrarConta(ContaContext conta)
{
    Console.WriteLine("=== Cadastro de conta ===\n");
    Console.WriteLine("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o titular da conta: ");
    string titular = Console.ReadLine();
    Console.WriteLine("Terá depósito inicial (s/n)");
    char escolha = char.Parse(Console.ReadLine().ToLower();

}