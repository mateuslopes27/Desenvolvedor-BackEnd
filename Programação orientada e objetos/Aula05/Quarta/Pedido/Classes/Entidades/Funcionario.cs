namespace Pedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente.
    internal class Funcionario
    {
        //1° Campos
        private string nome;


        //2° Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //3° Construtores
        public Funcionario(string nome)
        {
            Nome = nome;
        }
    }
}
