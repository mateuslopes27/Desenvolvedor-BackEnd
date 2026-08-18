using Banco;
using System.CodeDom.Compiler;
namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaração de variáveis
        string nome;
        int numero;
        double saldo, quantia;
        bool erro = false;
        ContaBancaria conta1;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nome = textBox1.Text;
                numero = int.Parse(textBox2.Text);
                temp = textBox3.Text;
                saldo = double.Parse(textBox3.Text);
                if(TextBox3.Text == "")
                {
                    saldo = 0;
                }
                else
                {
                    saldo = double.Parse(textBox3.Text);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro das invalidos, Erro: {e.Message}");
            }
            if (!erro)
            {
                conta1 = new ContaBancaria(nome, numero, saldo);

            }

            conta1 = new ContaBancaria(nome, numero, saldo);

            MessageBox.Show(conta1.ExibirDados());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
