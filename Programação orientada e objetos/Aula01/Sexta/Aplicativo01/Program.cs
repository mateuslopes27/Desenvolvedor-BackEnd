using Aplicativo01;

//Declaracao de variaveis
double raio;

//Entrada de dados
Console.WriteLine("Entre com o valor do raio da circunferencia:");
raio = double.Parse(Console.ReadLine());

//Processamento de dados

//Saida de dados
Console.WriteLine($"A circunferência é: {Calculadora.Circunferencia(raio):f2}\n O volume é: {Calculadora.Volume(raio):f2}");
Calculadora.PI();