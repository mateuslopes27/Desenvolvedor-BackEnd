//Declarando variaveis
double precophora;
double horastra;
double salariobruto;
double inss;
double fgts;
double totaldesconto1;
double totaldesconto2;
double totaldesconto3;
double totaldesconto4;
double desconto1;
double desconto2;
double desconto3;
double soma1;
double soma2;
double soma3;
double soma4;
double somanada;

try
{
    //Entrada de dados
    Console.WriteLine("Quanto você ganha por hora? ");
    precophora = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantas horas por mes você trabalha? ");
    horastra = double.Parse(Console.ReadLine());

    //Processando dados
    salariobruto = precophora * horastra;
    inss = (salariobruto * 10) / 100;
    fgts = (salariobruto * 11) / 100;
    desconto1 = ((precophora * horastra) * 5) / 100;
    desconto2 = ((precophora * horastra) * 10) / 100;
    desconto3 = ((precophora * horastra) * 20) / 100;
    somanada = salariobruto - (inss + fgts);
    totaldesconto1 = (inss + fgts);
    totaldesconto2 = (inss + fgts) + desconto1;
    totaldesconto3 = (inss + fgts) + desconto2;
    totaldesconto4 = (inss + fgts) + desconto3;
    soma1 = salariobruto - totaldesconto2;
    soma2 = salariobruto - totaldesconto3;
    soma3 = salariobruto - totaldesconto4;

    //Saida de dados
    if (salariobruto <= 900)
    {
        Console.WriteLine($"Salario Bruto: R${salariobruto:f2}\nINSS(10%): R${inss:f2}\nFGTS(11%): R${fgts:f2}\nTotal de desconto: {totaldesconto1:f2}\nSalário Liquido: R${somanada:f2}");
    }
    else if (salariobruto > 900 && salariobruto <= 1500)
    {
        Console.WriteLine($"Salario Bruto: R${salariobruto:f2}\nINSS(10%): R${inss:f2}\nFGTS(11%): R${fgts:f2}\nTotal de desconto: {totaldesconto2:f2}\nIR(5%): {desconto1:f2}\nSalário Liquido: R${soma1:f2}");
    }
    else if (salariobruto > 1500 && salariobruto <= 2500)
    {
        Console.WriteLine($"Salario Bruto: R${salariobruto:f2}\nINSS(10%): R${inss:f2}\nFGTS(11%): R${fgts:f2}\nTotal de desconto: {totaldesconto3:f2}\nIR(5%): {desconto2:f2}\nSalário Liquido: R${soma2:f2}");
    }
    else
    {
        Console.WriteLine($"Salario Bruto: R${salariobruto:f2}\nINSS(10%): R${inss:f2}\nFGTS(11%): R${fgts:f2}\nTotal de desconto: {totaldesconto4:f2}\nIR(5%): {desconto3:f2}\nSalário Liquido: R${soma3:f2}");
    }
}
catch
{

}