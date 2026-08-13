using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    internal class _01
    {
        //Campos
        public double altura, largura, area, perimetro, diagonal;

        //Construtor
        public _01(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;

            this.area = altura * largura;
            this.perimetro = 2 * (altura + largura);
            this.diagonal = Math.Sqrt(altura * altura + largura * largura);
        }
    }
}
