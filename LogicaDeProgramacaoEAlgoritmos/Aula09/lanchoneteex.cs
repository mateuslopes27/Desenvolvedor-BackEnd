// Declaração de variáveis

int n, pedido, cxrquente = 0, xsalada = 0, xbacon = 0, torradasim = 0, refrigerante = 0;
double total = 0;

try
{
    while (true)
    {
        // Entrada de dados
        Console.Write("Quantos pedidos irá fazer? ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "========================================\n" +
                "       CARDÁPIO DA LANCHONETE\n" +
                "========================================\n" +
                "CÓDIGO | ITEM            | PREÇO\n" +
                "----------------------------------------\n" +
                "  1    | Cachorro Quente | R$ 4,50\n" +
                "  2    | X-Salada        | R$ 4,50\n" +
                "  3    | X-Bacon         | R$ 5,00\n" +
                "  4    | Torrada Simples | R$ 2,00\n" +
                "  5    | Refrigerante    | R$ 1,50\n" +
                "========================================"
            );

            Console.Write("Digite o código do item que deseja pedir: ");
            pedido = int.Parse(Console.ReadLine());

            if (pedido == 1)
            {
                cxrquente++;
                total += 4.50;

                Console.WriteLine(
                    "Pedido anotado!\n" +
                    "Aguarde seu pedido ficar pronto...");

                await Task.Delay(3000);

                Console.WriteLine("Seu Cachorro Quente está pronto!");
            }
            else if (pedido == 2)
            {
                xsalada++;
                total += 4.50;

                Console.WriteLine(
                    "Pedido anotado!\n" +
                    "Aguarde seu pedido ficar pronto...");

                await Task.Delay(3000);

                Console.WriteLine("Seu X-Salada está pronto!");
            }
            else if (pedido == 3)
            {
                xbacon++;
                total += 5.00;

                Console.WriteLine(
                    "Pedido anotado!\n" +
                    "Aguarde seu pedido ficar pronto...");

                await Task.Delay(3000);

                Console.WriteLine("Seu X-Bacon está pronto!");
            }
            else if (pedido == 4)
            {
                torradasim++;
                total += 2.00;

                Console.WriteLine(
                    "Pedido anotado!\n" +
                    "Aguarde seu pedido ficar pronto...");

                await Task.Delay(3000);

                Console.WriteLine("Sua Torrada Simples está pronta!");
            }
            else if (pedido == 5)
            {
                refrigerante++;
                total += 1.50;

                Console.WriteLine(
                    "Pedido anotado!\n" +
                    "Aguarde seu pedido ficar pronto...");

                await Task.Delay(3000);

                Console.WriteLine("Seu Refrigerante está pronto!");
            }
            else
            {
                Console.WriteLine("Código inválido. Por favor, digite um código válido.");
                i--;
                continue;
            }
    }

        Console.WriteLine("\n========================================");
        Console.WriteLine("           PEDIDOS          ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cachorro Quente: {cxrquente:f2}");
        Console.WriteLine($"X-Salada:        {xsalada:f2}");
        Console.WriteLine($"X-Bacon:         {xbacon:f2}");
        Console.WriteLine($"Torrada Simples: {torradasim:f2}");
        Console.WriteLine($"Refrigerante:    {refrigerante:f2}");
        Console.WriteLine($"Total:        R$ {total:F2}");
        Console.WriteLine("========================================\n");

        break;
    }
}
catch (FormatException e)
{
    Console.WriteLine($"Erro: {e}" );
}
finally
{
    Console.WriteLine("Obrigado por utilizar nosso sistema de pedidos!\nFechando o programa...");
}