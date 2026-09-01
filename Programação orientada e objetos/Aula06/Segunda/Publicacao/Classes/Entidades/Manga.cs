using System;
using System.Collections.Generic;
using System.Text;

namespace Publicacao.Classes.Entidades
{
    internal class Manga : item
    {
		private int numero;
		private string mes;

		public string MesDePublicacao
		{
			get { return mes; }
			set { mes = value; }
		}


		public int NumeroDoManga
		{
			get { return numero; }
			set { numero = value; }
		}

	}
}
