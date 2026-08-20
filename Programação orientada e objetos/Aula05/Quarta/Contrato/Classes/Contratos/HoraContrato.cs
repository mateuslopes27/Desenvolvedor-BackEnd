namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
		//Campos
		private int horas;
		private double valor;


        //Propriedades
        public double ValorPorHora
        {
			get { return (double)valor; }
			set { valor = value; }
		}


		public int HorasTrabalhadas
		{
			get { return horas; }
			set { horas = value; }
		}

        //Construtor
        public HoraContrato(double valorPorHora, int horasTrabalhadas)
        {
            ValorPorHora = valorPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        //Metodos
        public double Pagamento()
        {
            return ValorPorHora * HorasTrabalhadas;
        }


    }
}
