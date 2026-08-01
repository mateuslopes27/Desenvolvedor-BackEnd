//Declaração de variaveis
using System.Xml;

int codigo, quantidade;
double preco;

//Entrada de dados
Console.Write("Digite o código do produto: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de produto: ");
quantidade = int.Parse(Console.ReadLine());

//Estrutura de controle de seleção - switch case
switch(codigo)
{
    case 1:
        //Produto 1 - R$5.00
        Console.WriteLine($"Valor a pagar: R${quantidade * 5.0:f2}");

        break;
    case 2:
        //Produto 2 - R$3.50
        Console.WriteLine($"Valor a pagar: R${quantidade * 3.50:f2}");

        break;

    case 3:
        //Produto 3 - R$4.80
        Console.WriteLine($"Valor a pagar: R${quantidade * 4.80:f2}");

        break;

    case 4:
        //Produto 4 - R$8.90
        Console.WriteLine($"Valor a pagar: r${quantidade * 8.90:f2}");

        break;
    case 5:
        //Produto 5 - R$7.32
        Console.WriteLine($"Valor a pagar: R${quantidade * 7.32:f2}");

        break;
    default:
        Console.WriteLine("Código inválido, tente novamente!");
        break;

}