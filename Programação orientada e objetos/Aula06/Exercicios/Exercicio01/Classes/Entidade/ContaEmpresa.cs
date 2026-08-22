namespace Banco.Classes.Entidades
{
    internal class ContaParaEmpresa : Conta
    {
        //Campos
        private double limiteDeEmprestimo;

        //Propriedades
        protected double LimiteDeEmprestimo
        {
            get { return limiteDeEmprestimo; }
            set { limiteDeEmprestimo = value; }
        }

        //Construtor
        public ContaParaEmpresa(
            int numeroDaConta,
            string titularDaConta,
            double limiteDeEmprestimo)
            : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        public ContaParaEmpresa(
            int numeroDaConta,
            string titularDaConta,
            double saldoDaConta,
            double limiteDeEmprestimo)
            : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        //Métodos
        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                SaldoDaConta += quantia;
            }
        }
    }
}