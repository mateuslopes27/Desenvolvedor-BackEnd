using System;
using System.Collections.Generic;
using System.Text;

namespace Publicacao.Classes.Entidades
{
    internal class item
	{
		private string titulo;
		private DateTime ano;
		private int quantidade;

		protected int Quantidade
		{
			get { return quantidade; }
			set { quantidade = value; }
		}
		protected string Titulo { get { return titulo; } set { titulo = value; } }

		protected DateTime Ano
		{
			get { return ano; }
			set {  ano = value; }
		}


		public virtual string Exibir()
		{
			return ($"Dados do item:\n" +
				$"\tTitulo: {Titulo}\n" +
				$"\tAno de publicação: {Ano}\n" +
				$"\tQuantidade disponivel: {Quantidade}");
		}


	}
}
