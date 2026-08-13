using Exercicio03;
//Entrada de dados
Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
double nota3 = double.Parse(Console.ReadLine());

//Criação do objeto
Exertres aluno = new Exertres(nome, nota1, nota2, nota3);

//Saída de dados
Console.WriteLine($"Nota Final: {aluno.notafinal:F2}");
if (aluno.notafinal >= 60)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine($"Reprovado! Faltaram {60 - aluno.notafinal:F2} pontos para aprovação.");
}