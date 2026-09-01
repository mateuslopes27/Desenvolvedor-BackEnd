using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Classes.Entidades
{
    internal class AluguelDeCarro
    {
		//Campos
		private DateTime inicio;
		private DateTime fim;

		//Propriedades

		public DateTime InicioLocacao
		{
			get { return inicio; }
			set { inicio = value; }
		}

		public DateTime FimLocacao
		{
			get { return fim; }
			set { fim = value; }
		}


	}
}
