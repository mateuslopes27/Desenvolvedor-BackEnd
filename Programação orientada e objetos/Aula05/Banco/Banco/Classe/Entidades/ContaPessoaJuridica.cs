using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Classe.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica
    {
		private double limite;

        public ContaPessoaJuridica(string titularDaConta, int numeroDaConta) : base(titularDaConta, numeroDaConta)
        {
        }

        public double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}

	}
}
