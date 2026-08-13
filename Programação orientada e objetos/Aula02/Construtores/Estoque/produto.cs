using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Estoque
{
    internal class produto
    {
        //Campos
        string nome;
        int quantidade;
        double preco;

        //Construtor
        public produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void adicionarprodutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void removerprodutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public double valorTotalEmEstoque()
        {
            return quantidade * preco;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Quantidade em estoque: " + quantidade);
            Console.WriteLine("Preço unitário: " + preco.ToString("F2"));
            Console.WriteLine("Valor total em estoque: " + valorTotalEmEstoque().ToString("F2"));
        }

    }
}
