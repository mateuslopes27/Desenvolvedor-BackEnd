using Moeda;
//Entrada de dados
Console.WriteLine("Qual a cotação do dolar:");
Dolares.cotacao = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com a quantidade de dolares que irá Comprar:");
Dolares.compra = double.Parse(Console.ReadLine());

//Processamento de dados
Dolares.total = Dolares.cotacao * Dolares.compra;
Dolares.iof = Dolares.total * 0.06;
Dolares.resultado = (Dolares.cotacao * Dolares.compra) + Dolares.iof;

//Saída de dados
Console.WriteLine($"Valor a ser pago em reais: {Dolares.resultado:f2}");