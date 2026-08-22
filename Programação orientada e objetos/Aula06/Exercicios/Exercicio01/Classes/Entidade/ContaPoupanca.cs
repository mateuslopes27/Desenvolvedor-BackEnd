namespace Banco.Classes.Entidades
{
    internal class ContaPoupanca : Conta
    {
        //Campos
        private double taxaDeJuros;

        //Propriedades
        protected double TaxaDeJuros
        {
            get { return taxaDeJuros; }
            set { taxaDeJuros = value; }
        }

        //Construtor
        public ContaPoupanca(
            int numeroDaConta,
            string titularDaConta,
            double taxaDeJuros)
            : base(numeroDaConta, titularDaConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public ContaPoupanca(
            int numeroDaConta,
            string titularDaConta,
            double saldoDaConta,
            double taxaDeJuros)
            : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        //Métodos
        public void AtualizacaoDeSaldo()
        {
            SaldoDaConta += SaldoDaConta * TaxaDeJuros;
        }

        public override void Saque(double quantia)
        {
            SaldoDaConta -= quantia;
        }
    }
}