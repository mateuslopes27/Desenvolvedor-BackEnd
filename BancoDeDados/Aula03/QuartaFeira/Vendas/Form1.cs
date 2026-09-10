namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        void CarregarDados()
        {
            try
            {
                using (var contexto = new Classes.Contextos.VendasContexto())
                {
                    var vendas = contexto.Vendas.ToList();
                    dataGridView1.DataSource = vendas;
                    FormatarGrade();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
        void FormatarGrade()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome do Produto";
            dataGridView1.Columns[2].HeaderText = "Quantidade";
            dataGridView1.Columns[3].HeaderText = "Preço Unitário";
            dataGridView1.Columns[4].HeaderText = "Data da Venda";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;
        }
    }
}
