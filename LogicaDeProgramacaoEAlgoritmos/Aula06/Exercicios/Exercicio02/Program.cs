//Declarando variaveis
double salario;
double aumento1;
double aumento2;
double aumento3;
double aumento4;
double novosalario1;
double novosalario2;
double novosalario3;
double novosalario4;

try
{
    //Entrada de dados
    Console.WriteLine("Qual seu salário?");
    salario = double.Parse(Console.ReadLine());

    //Processamento de dados
    aumento1 = (salario * 20) / 100;
    aumento2 = (salario * 15) / 100;
    aumento3 = (salario * 10) / 100;
    aumento4 = (salario * 5) / 100;
    novosalario1 = salario + aumento1;
    novosalario2 = salario + aumento2;
    novosalario3 = salario + aumento3;
    novosalario4 = salario + aumento4;

    //Saida de dados
    if (salario <= 280)
    {
        Console.WriteLine($"Seu salario será de {novosalario1:f2}\nSalario antes do aumento: {salario}\nPercentual de aumento aplicado: 20%\nO valor do aumento: R${aumento1:f2}");
    }
    else if (salario > 280 && salario <= 780)
    {
        Console.WriteLine($"Seu salario será de {novosalario2:f2}\nSalario antes do aumento: {salario}\nPercentual de aumento aplicado: 15%\nO valor do aumento: R${aumento2:f2}");
    }
    else if (salario > 700 && salario <= 1500)
    {
        Console.WriteLine($"Seu salario será de {novosalario3:f2}\nSalario antes do aumento: {salario}\nPercentual de aumento aplicado: 10%\nO valor do aumento: R${aumento3:f2}");
    }
    else
    {
        Console.WriteLine($"Seu salario será de {novosalario4:f2}\nSalario antes do aumento: {salario}\nPercentual de aumento aplicado: 5%\nO valor do aumento: R${aumento4:f2}");
    }
}
catch
{
    Console.WriteLine("Digite algo válido!");
}