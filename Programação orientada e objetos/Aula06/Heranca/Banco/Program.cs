Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n\t1 - Conta normal\n\t2 - Conta Poupança\n\t3 - Conta Empresa\n");
int selecao = int.Parse(Console.ReadLine());
switch (selecao)
{
    case 1:
        Console.WriteLine("Selecionado conta normal!");
        break;
    case 2:
        Console.WriteLine("Selecionado conta poupança!");
        break;
    case 3:
        Console.WriteLine("Selecionado conta empresa!");
        break;
    default:
        Console.WriteLine("Tente novamente");
        break;
}

void Opcao1()
{
    Console.WriteLine("Deseja fazer deposito inicial ?");
    char op = char.Parse(Console.ReadLine());
    if (op =='n')
    {

    }
    else
    {
        Console.WriteLine("Qual valor do deposito inicial ?");
    }
}