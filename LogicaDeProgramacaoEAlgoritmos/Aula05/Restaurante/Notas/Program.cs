//Declaração variaveis
double nota1, nota2, notafinal;
try
{
    //Entrada de dados
    Console.Write("Digite a 1° nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a 2° nota: ");
    nota2 = double.Parse(Console.ReadLine());

    //Processamento de dados
    Nota();

    //Saída de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if (notafinal < 60 & notafinal < 70)
    {
        Console.WriteLine("Voçê está de recuperação!");
    }
    else if (notafinal == 80)
    {
        Console.WriteLine("Parabens pela nota!");
    }
    else
    {
        Console.WriteLine("Voçê está aprovado!");
    }
}

catch 
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}