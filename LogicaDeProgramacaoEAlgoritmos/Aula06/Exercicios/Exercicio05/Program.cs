//Declarar variaveis
double ladoa;
double ladob;
double ladoc;
double medida1;
double medida2;
double medida3;

try
{
    //Entrada de dados
    Console.Write("Qual valor do lado A: ");
    ladoa = double.Parse(Console.ReadLine());
    Console.Write("Qual valor do lado B: ");
    ladob = double.Parse(Console.ReadLine());
    Console.Write("Qual valor do lado C: ");
    ladoc = double.Parse(Console.ReadLine());

    //Processamento de dados
    medida1 = ladob + ladoc;
    medida2 = ladoa + ladoc;
    medida3 = ladob + ladoa;

    //Saída de dados
    if (medida1 > ladoa && medida2 > ladob && medida3 > ladoc & ladoa == ladob && ladob == ladoc && ladoc == ladoa)
    {
        Console.WriteLine("Seu Triangulo é Equilátero!");
    }
    else if (medida1 > ladoa && medida2 > ladob && medida3 > ladoc && ladoa == ladob || ladob == ladoc || ladoc == ladoa)
    {
        Console.WriteLine("Seu triangulo é Isóceles!");
    }
    else if (medida1 > ladoa && medida2 > ladob && medida3 > ladoc && ladoa != ladob && ladob != ladoc && ladoc != ladoa)
    {
        Console.WriteLine("Seu triangulo é Escaleno!");
    }
    else if (medida1 < ladoa || medida2 < ladob || medida3 < ladoc)
    {
        Console.WriteLine("Com esse números não da pra se fazer um triangulo!");
    }
}
catch
{
    Console.WriteLine("Digite valores válidos!");
}