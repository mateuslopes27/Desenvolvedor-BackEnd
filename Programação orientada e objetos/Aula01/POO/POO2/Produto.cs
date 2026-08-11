internal class Produto
{
    //Campos
    public string nome;
    public double preco;
    public int quantidade;
    //Metodos
    public void ExibirDados()
    {
        Console.WriteLine($"Nome do produto: {nome}\nValor de compra: {preco}\nQuantidade em estoque: {quantidade}\nValor total em estoque: {ValorTotalEmEstoque()}");
    }

    public void AdicionarProduto(int q)
    {
        quantidade += q;
    }

    public void RemoverProduto(int q)
    {
        quantidade -= q;
    }
    
    public double ValorTotalEmEstoque()
    {
        return preco * quantidade;
    }
}