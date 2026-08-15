using System.Runtime.CompilerServices;

namespace Moeda
{
    internal static class Dolares
    {
        //Campos
        public static double cotacao, compra, total, iof, resultado;


        //Metodos
        public static void Definir(double cotacao, double compra)
        {
            Dolares.cotacao = cotacao;
            Dolares.compra = compra;
        }

        public static void Total(double total)
        {
            Dolares.total = cotacao * compra;
        }

        public static void Iof(double iof)
        {
            Dolares.iof = total * 0.06;
        }

        public static void Resultado(double resultado)
        {
            Dolares.resultado = (cotacao * compra) * (1 + iof);
        }
    }
}
