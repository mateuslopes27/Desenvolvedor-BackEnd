//Declarando as variaveis
string M;
string V;
string N;
string opcao;


try
{
    //Entrada de dados
    Console.WriteLine("Digite M - Matutino, V - Vespertino ou N - Noturno: ");
    opcao = Console.ReadLine();

    //Processamento de dados
    M = "M";
    V = "V";
    N = "N";
    //Saida de dados
    if (opcao == M)
    {
        Console.WriteLine("Bom dia!");
    }
    else if (opcao == V)
    {
        Console.WriteLine("Boa tarde!");
    }
    else if (opcao == N)
    {
        Console.WriteLine("Boa noite!");
    }
    else
    {
        Console.WriteLine("Valor Inválido");
    }
}

catch
{
  Console.WriteLine("Escreva algo valido");
}