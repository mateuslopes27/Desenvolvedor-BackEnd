namespace Banco
{
    internal class ContaBancaria
    {
        //1° - Campos
        private string titular;
        private int numero, valor;
        private double saldo;

        //2 - Propriedades
        public string TitularDaConta 
        {
            get { return titular; } 
            set 
            {
                if (value != null | value != "")
                {
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Valor de campo invalido");
                }
            }
        }
        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = valor; }
        }
        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = valor; }
        }

        //3 - Construtores
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }

        //4 - Metodos
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("Valor invalido, insira um valor positivo"); ;
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }
        }
        public string ExibirDados()
        {
            return $"Titular: {TitularDaConta}\nNúmero da conta: {NumeroDaConta}\nSaldo: {SaldoDaConta}";
        }
    }
}
