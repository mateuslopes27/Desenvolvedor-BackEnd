using System;
using System.Collections.Generic;
using System.Text;

namespace Publicacao.Classes.Entidades
{
    internal class Livro : item
    {
		//Campos
		private string autor;
		private int paginas;


        public int PaginasLivro
		{
			get { return paginas; }
			set { paginas = value; }
		}


		public string AutorLivro
		{
			get { return autor; }
			set { autor = value; }
		}

        public Livro(int paginasLivro, string autorLivro)
        {
            PaginasLivro = paginasLivro;
            AutorLivro = autorLivro;
        }
	}
}
