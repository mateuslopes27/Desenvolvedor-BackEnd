namespace Triangulo_Com_Poo
{
    internal class Triangulo
    {
        //Membros
        //1° Membros -> Campos
        public double a, b, c;

        //2° Membros -> Metodos
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
