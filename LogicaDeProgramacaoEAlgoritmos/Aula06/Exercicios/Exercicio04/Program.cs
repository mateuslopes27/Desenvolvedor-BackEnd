//Declarando variaveis
double dom;
double seg;
double ter;
double qua;
double qui;
double sex;
double sab;
double escolha;
double valor; 

try
{
    //Entrada de dados
    Console.Write("Escreva o dia da semana conforme os numeros\n1 - Domindo\n2 - Segunda\n3 - Terça\n4 - Quarta\n5 - Quinta\n6 - Sexta\n7 - Sabado\nEscolha: ");
    escolha = double.Parse(Console.ReadLine());
    //Processamento de dados
    valor = escolha;
    //Saida de dados
    if (valor == 1)
    {
        Console.WriteLine($"Hoje é Domingo!");
    }
    else if (valor == 2)
    {
        Console.WriteLine($"Hoje é Segunda-Feira!");
    }
    else if (valor == 3)
    {
        Console.WriteLine($"Hoje é Terça-Feira!");
    }
    else if (valor == 4)
    {
        Console.WriteLine($"Hoje é Quarta-Feira!");
    }
    else if (valor == 5)
    {
        Console.WriteLine($"Hoje é Quinta-Feira!");
    }
    else if (valor == 6)
    {
        Console.WriteLine($"Hoje é Sexta-Feira!");
    }
    else if (valor == 7)
    {
        Console.WriteLine($"Hoje é Sabado!");
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}
catch
{
    Console.WriteLine("Tente algo válido!");
}