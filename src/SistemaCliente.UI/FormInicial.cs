using System;
using System.Linq;
using System.Windows.Forms;
using SistemaCliente.DI;
using SistemaCliente.Infra;

namespace SistemaCliente
{
    public partial class FormInicial : Form
    {
        private const string connectionString = @"Database=db_sistemaCliente;Server=BIANCA-PC\B1;user=sa;pwd=sap@123;";
        private const string providerName = @"System.Data.SqlClient";

        private IClienteRepositorio _repositorio;
        private Cliente cliente;

        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            TotalRegistros();
        }

        private void CarregaGrid()
        {
            _repositorio = new ClienteRepositorio(connectionString, providerName);
            dgdClientes.DataSource = _repositorio.ObterTodos().ToList();
            TotalRegistros();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            var form = new CadastroCliente();
            form.Show();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            pesquisarClienteTextBox.Text = "";
        }
        

        public void ProcessarNomePesquisado(string filtroNomeProduto)
        {
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TotalRegistros()
        {
            var linhas = dgdClientes.RowCount;
            label2.Text = "Total de registros: " + linhas;
        }
    }
}
