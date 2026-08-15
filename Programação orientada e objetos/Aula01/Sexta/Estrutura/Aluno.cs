namespace Estrutura
{
    internal struct Aluno
    {
        //Membros
        //Campos
        public string nome;
        public int cpf;
        double altura;

        //Construtores
        public Aluno(string nome, int cpf, double altura)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.altura = altura;
        }

        //Metodos
        public double Idade(int idade)
        {
            return idade / 365;
        } 

    }
}
