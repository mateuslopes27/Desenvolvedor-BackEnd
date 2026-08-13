namespace Exercicio02
{
    internal class Exerdois
    {
        //Campos
        public string nome;
        public double salariob, imposto, salariol, porcentagem1, porcentagem2, salariold;

        //Construtor
        public Exerdois(string nome, double salariob, double imposto)
        {
            this.nome = nome;
            this.salariob = salariob;
            this.imposto = imposto; 
            this.porcentagem1 = porcentagem1;
            this.porcentagem2 = porcentagem2;
            this.salariold = salariold;

            this.salariol = salariob - imposto;
            this.porcentagem2 = (imposto / 100) * salariol;
            salariold = salariol - porcentagem2;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = salariol * (porcentagem / 100);
            salariol += aumento;
        }
    }
}
