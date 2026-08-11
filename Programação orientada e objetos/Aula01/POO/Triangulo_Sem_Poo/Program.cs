//Declaração de variaveis

double ladoA_x, ladoB_x, ladoC_x;
double ladoA_y, ladoB_y, ladoC_y;
double perimetro_x, perimetro_y;
double area_x, area_y;

//Entrada de dados
Console.WriteLine("Entre com as medidas do triangulo X: ");
Console.WriteLine("Lado A:");
ladoA_x = double.Parse(Console.ReadLine());
Console.WriteLine("Lado B:");
ladoB_x = double.Parse(Console.ReadLine());
Console.WriteLine("Lado C:");
ladoC_x = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triangulo Y: ");
Console.WriteLine("Lado A:");
ladoA_y = double.Parse(Console.ReadLine());
Console.WriteLine("Lado B:");
ladoB_y = double.Parse(Console.ReadLine());
Console.WriteLine("Lado C:");
ladoC_y = double.Parse(Console.ReadLine());

//Processamento de dados
//Perimetros do traingulo
perimetro_x = (ladoA_x + ladoB_x + ladoC_x) / 2;
perimetro_y = (ladoA_y + ladoB_y + ladoC_y) / 2;

//Area do triangulo
area_x = Math.Sqrt(perimetro_x * (perimetro_x - ladoA_x) * (perimetro_x - ladoB_x) * (perimetro_x - ladoC_x));
area_y = Math.Sqrt(perimetro_y * (perimetro_y - ladoA_y) * (perimetro_y - ladoB_y) * (perimetro_y - ladoC_y));

//Saida de dados
Console.WriteLine($"Area do triangulo X: {area_x}");
Console.WriteLine($"Area do triangulo Y: {area_y}");
Console.WriteLine(area_x > area_y ? "O triangulo X tem maior area" : "O triangulo Y tem maior area");