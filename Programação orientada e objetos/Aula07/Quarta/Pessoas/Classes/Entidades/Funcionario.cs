using

using System.ComponentModel;

namespace Pessoas.Classes.Entidades
{
    internal class Funcionario : IPagamento
    {
        //Campos
        private int myVar;
        private int MyVar;
        private int myyVar;



        //Propriedades
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int MyyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int MyyyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //Construtores
        public ContaPoupanca(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta.numeroDaConta)
        {
            taxaDeJuros = taxa;
        }



        //Metodos
    }
}
