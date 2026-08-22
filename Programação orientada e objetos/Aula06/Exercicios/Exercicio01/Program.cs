using Banco.Classes.Entidades;
using Banco.Classes.Identificadores;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Escolha o tipo de conta:");
            Console.WriteLine("1 - Conta Poupança");
            Console.WriteLine("2 - Conta para Empresa");
            Console.Write("Digite a opção: ");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Conta conta;

            if (opcao == (int)TipoConta.Poupanca)
            {
                Console.Write("Digite a taxa de juros: ");
                double taxaDeJuros = double.Parse(Console.ReadLine());

                conta = new ContaPoupanca(
                    numero,
                    titular,
                    taxaDeJuros
                );

                Console.WriteLine();
                Console.WriteLine("Conta Poupança criada com sucesso!");
            }
            else if (opcao == (int)TipoConta.Empresa)
            {
                Console.Write("Digite o limite de empréstimo: ");
                double limiteDeEmprestimo = double.Parse(Console.ReadLine());

                conta = new ContaParaEmpresa(
                    numero,
                    titular,
                    limiteDeEmprestimo
                );

                Console.WriteLine();
                Console.WriteLine("Conta para Empresa criada com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            Console.Write("Digite o valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            conta.Deposito(valorDeposito);

            Console.WriteLine("Depósito realizado com sucesso!");
            Console.Write("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            conta.Saque(valorSaque);

            Console.WriteLine("Saque realizado com sucesso!");

            // Verifica se a conta é poupança
            if (conta is ContaPoupanca contaPoupanca)
            { 

                contaPoupanca.AtualizacaoDeSaldo();

                Console.WriteLine("Atualização de saldo realizada!");
            }

            // Verifica se a conta é para empresa
            if (conta is ContaParaEmpresa contaEmpresa)
            {

                Console.Write("Deseja realizar um empréstimo? (s/n): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    Console.Write("Digite o valor do empréstimo: ");
                    double valorEmprestimo = double.Parse(Console.ReadLine());

                    contaEmpresa.Emprestimo(valorEmprestimo);

                    Console.WriteLine("Operação de empréstimo realizada!");
                }
            }


            Console.WriteLine();
            Console.WriteLine("Número da conta: " + numero);
            Console.WriteLine("Titular: " + titular);

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
