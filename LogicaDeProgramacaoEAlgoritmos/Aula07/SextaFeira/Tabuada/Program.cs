//Entrada de dados
Console.Write("Deseja a tabuada para qual valor ? ");
int n = int.Parse(Console.ReadLine());

//Estrutura do for
for (int i = 0; i < 1000000000; i++)
{
    Console.WriteLine($" {n} X {i+1} = {n * (i+1)}");
}