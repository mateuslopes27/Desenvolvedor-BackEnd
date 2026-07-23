
//Criação das variáveis
int numero1;
int numero2;
int numero3;

int logica1;
int logica2;
int logica3;
int logica4;

int pergunta1;
int pergunta2;
int pergunta3;
int pergunta4;



//Entrada de dados
Console.WriteLine("Digite o primeiro valor: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
numero3 = int.Parse(Console.ReadLine());

//Processamento de dados
pergunta1 = numero1 == numero2;
pergunta2 = numero1 != numero2;
pergunta3 = numero2 > numero1;
pergunta4 = numero2 <= numero3;

logica1 = pergunta1 & pergunta3;
logica2 = pergunta2 | pergunta4;
logica3 = !pergunta1;

//Processamento de dados e saída de dados
Console.WriteLine("O primeiro valor é igual ao terceiro valor?R: " + (numero1 == numero3 ? "Verdadeiro" : "Falso"));
Console.WriteLine("O primeiro valor é diferente do segundo valor?R: " + (numero1 != numero2 ? "Verdadeiro" : "Falso"));
Console.WriteLine("O primeiro valor é maior que o primeiro valor?R: " + (numero1 < numero2 ? "Verdadeiro" : "Falso"));
Console.WriteLine("O primeiro valor é menor ou igual que o terceiro valor?R: " + (numero2 <= numero3 ? "Verdadeiro" : "Falso"));
Console.WriteLine("--Lógicas--");
Console.WriteLine($"Se a pergunta 1 e perguta 3 são verdadeiras. R; {(logica1 ? "Verdadeira" : "Falso")}");
Console.WriteLine($"Se a pergunta 1 e perguta 3 são verdadeiras. R; {(logica2 ? "Verdadeira" : "Falso")}");
Console.WriteLine($"Se a pergunta 1 e perguta 3 são verdadeiras. R; {(logica3 ? "Verdadeira" : "Falso")}");

