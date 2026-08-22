namespace Banco.Classes.Entidades
{
    internal class Conta
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;

        //Propriedades
        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }

        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor
        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }

        public Conta(int numeroDaConta, string titularDaConta, double saldoDaConta)
            : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        //Métodos
        public virtual void Saque(double quantia)
        {
            SaldoDaConta -= quantia;
            SaldoDaConta -= 5.00;
        }

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
    }
}