// Declaração de variáveis
int turistas, veiculos, totalTuristas;
string movimento;

veiculos = 0;
totalTuristas = 0;
turistas = 0;

while (true)
{
    try
    { //Entrada de dados
        while (true)
        {
            Console.Write("Informe o movimento (Sair, Entrando ou Voltando): ");
            movimento = Console.ReadLine();

            if (movimento == "sair" || movimento == "Sair")
            {
                break;
            }

            Console.Write("Quantidade de turistas: ");
            turistas = int.Parse(Console.ReadLine());

            if (movimento == "entrando" || movimento == "Entrando")
            {
                veiculos++;
                totalTuristas += turistas;
            }
            else if (movimento == "voltando" || movimento == "Voltando")
            {
                veiculos--;
                totalTuristas -= turistas;
            }
            else
            {
                Console.WriteLine("Inválido");
            }
        }

        //Saida de dados
        Console.WriteLine($"Veículos que ainda não retornaram: {veiculos}");
        Console.WriteLine($"Turistas que ainda não retornaram: {totalTuristas}");
        break;
    }
    catch (Exception erro)
    {
        Console.WriteLine($"Valor inválido, erro: {erro}");
    }
}
