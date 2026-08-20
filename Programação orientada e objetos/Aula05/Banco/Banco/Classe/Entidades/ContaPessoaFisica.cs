
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Classe.Entidades
{
    internal class ContaPessoaFisica
    {
		//Campos
		private int numero;
		private string titular;
		private double saldo;


        //Propriedades
        public string TitularDaConta
		{
			get { return titular; }
			set { titular = value; }
		}


		public int NumeroDaConta
		{
			get { return numero; }
			set { numero = value; }
		}

		public double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}


		//Construtor
        public ContaPessoaFisica(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
        }

		//Metodos
		public void Saque(double quantia)
		{
			SaldoDaConta -= quantia;
		}

		public void Deposito(double quantia)
		{
			SaldoDaConta += quantia;
		}

	}
}
