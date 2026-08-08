async Task Principal()
{
    Console.WriteLine("Pedido anotado!\nAguarde seu pedido ficar pronto...");
    await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkshake());
    Console.WriteLine("Seu pedido está entregue!");
}

async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando Hamburguer...");
    _ = Task.Delay(3000);
    Console.WriteLine("Seu Hamburguer está pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batata Frita...");
    Task.Delay(2500);
    Console.WriteLine("Sua Batata Frita está pronta!");
}

async Task PrepararMilkshake()
{
    Console.WriteLine("Preparando MilkShake...");
    Task.Delay(4000);
    Console.WriteLine("Seu MilkShake está pronto!");
}

Principal();