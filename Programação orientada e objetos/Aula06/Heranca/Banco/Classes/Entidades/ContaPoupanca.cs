namespace Banco.Classes.Entidades
{
    internal class ContaPoupanca
    {
		private double taxa;



		//Propriedades
		public double TaxaDeJuros
		{
			get { return taxa; }
			set { taxa = value; }
		}

		//Construtores
		public ContaPoupanca(int numeroDaConta, string titularDaConta) : base(numeroDaConta, titularDaConta)
		{
			TaxaDeJuros = taxa;
		}

		public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta) : base(numeroDaConta, titularDaConta, saldoDaConta)
		{
			TaxaDeJuros = taxa;
		}

		//Metodos 
		public override void Saque(double quantia)
		{
			SaldoDaConta -= quantia + (quantia + TaxaDeJuros);
		}

	}
}
