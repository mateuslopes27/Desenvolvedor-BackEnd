//Declarar variavel
using System.ComponentModel.DataAnnotations;

int x;

//Entrada de dados
Console.Write("Digite um número: ");
x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    if (i % 2 != 0)
    {
        Console.Write(i); 
    }
    else
    {
        Console.Write(i); 
    }
}