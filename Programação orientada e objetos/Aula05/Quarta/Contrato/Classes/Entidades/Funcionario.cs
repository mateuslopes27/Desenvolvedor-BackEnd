using Contrato.Classes.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contrato.Classes.Entidades
{
    internal class Funcionario
    {
		//Campos
		private string nome;
		private List<HoraContrato> contratos;


        //Propriedades
        public List<HoraContrato> Contratos
		{
			get { return contratos; }
			set { contratos = value; }
        }

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        //Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }

        //Metodos
        public void AdiocionarContrato(double valor, int horas)
        {
            if (Contratos == null)
            {
                Contratos = new List<HoraContrato>();
            }
            Contratos.Add(new HoraContrato(valor, horas));
            {
                HoraContrato contrato = new HoraContrato(valor, horas);
                contratos.Add(contrato);
            }
        }

    }
}
