//declaração de variáveis
int n, negativos = 0;
int[,] matriz;

while (true)
{
    //Entrada de dados
    Console.Write("Digite o tamanho da matriz: ");
    n = int.Parse(Console.ReadLine());
    if ( n > 10)
    {
        Console.WriteLine("O tamanho da matriz não pode ser maior que 10, tente novamente.");
        continue;
    }
    
    matriz = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Digite o valor para a posição [{i},{j}]: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }
    
    Console.WriteLine("Diagonal principal:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.Write(matriz[i, j] + "\t");
            }
        }

        Console.WriteLine("Quantidade de números negativos na matriz:");
        for (int j = 0; j < n; j++)
        {
            if (matriz[i, j] < 0)
            {
                negativos++;
            }
        }
        Console.WriteLine(negativos);
    }
}