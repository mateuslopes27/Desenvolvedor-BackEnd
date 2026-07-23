using static System.Console;

try
{
    //Declaração de variáveis
    double a, b, c;
    double area_q, area_t, area_tp;

    //Entrada de dados
    Write("Digite o valor de A: ");
    a = double.Parse(ReadLine());
    Write("Digite o valor de B: ");
    b = double.Parse(ReadLine());
    Write("Digite o valor de C: ");
    c = double.Parse(ReadLine());

    //Processamento de dados
    area_q = Math.Pow(a, 2);
    area_t = (a * b) / 2;
    area_tp = ((a + b) * c) / 2;

    //Saída de dados
    WriteLine($"A área do quadrado é: {area_q:f4}\nA área do triangula é: {area_t:f4}\nA área do trapezio é: {area_tp:f4}");
}
catch {
    WriteLine("Digite um valor valido!");
}
finally
{
    WriteLine("Encerrando programa...");
}



