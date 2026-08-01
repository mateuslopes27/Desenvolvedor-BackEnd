using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Sources;
double pessoasPermitidas = 0;

    try
    {
        //Entrada de dados
        
        Console.Write("Quantas pessoas irão entrar no brinquedo? ");
        Console.ForegroundColor = ConsoleColor.Red;
        int p = int.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite a altura min (em cm): ");
        Console.ForegroundColor = ConsoleColor.Red;
        int hmin = int.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite a altura max (em cm): ");
        Console.ForegroundColor = ConsoleColor.Red;
        int hmax = int.Parse(Console.ReadLine());
        Console.ResetColor();

        for (int i = 0; i < p; i++)
        {
            Console.Write($"Qual as alturas dos visitantes {i + 1}: ");
            Console.ForegroundColor = ConsoleColor.Red;
            int h = int.Parse(Console.ReadLine());
            Console.ResetColor();


            if (h == 0)
            {
                Console.WriteLine("Nulo!");
                continue;
            }
            else if (h < 0)
            {
                Console.WriteLine("Digite algo válido!");
                continue;
            }

            if (h >= hmin && h <= hmax)
            {
                pessoasPermitidas++;
            }


        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Valor inválido. Digite um numero inteiro!");
        Console.ResetColor();
    }

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine($"Total de pessoas que podem andar na montanha-russa: {pessoasPermitidas}");
Console.ResetColor();

