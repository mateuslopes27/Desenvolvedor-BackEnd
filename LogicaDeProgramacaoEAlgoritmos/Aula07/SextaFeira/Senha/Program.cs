//Declaração de variavel
int senha = 0;
int n = 0;
int i = 0;

try
{
    //Entrada de dados
    Console.Write("Crie uma senha: ");
    senha = int.Parse(Console.ReadLine());
    Console.WriteLine("Senha Criada!");
    Console.Write("Digite sua senha: ");
    n = int.Parse(Console.ReadLine());

    while (n != senha | i < 3)
    {
        if (i == 3)
        {
            break;
        }
        Console.Write("Senha incorreta, tente novamente: ");
        n = int.Parse(Console.ReadLine());
        i++;
        Console.WriteLine($"Numero de tentativas: {i}");

        if (senha == n)
        {
            Console.WriteLine("Acesso Permitido!");
        }
        
    }
}
catch
{
    Console.WriteLine("Digite uma senha válida! (SOMENTE NUMEROS)");
}


