namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string user = "SENAI";
            const int senha = 123456;

            bool ok1 = false;
            bool ok2 = false;

            string usuario = textBox2.Text;
            int pass = int.Parse(textBox1.Text);

            if (user == usuario)
            {
                ok1 = true;
            }
            else
            {
                ok1 = false;
            }

            if (senha == pass)
            {
                ok1 = true;
            }
            else
            {
                ok1 = false;
            }

            if (ok1 & ok2)
            {
                MessageBox.Show("Login realizado com sucesso!");

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
