using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using SistemaCliente.DI;
using SistemaCliente.Infra;
using System.Collections.Generic;

namespace SistemaCliente
{
    public partial class FormInicial : Form
    {
        private const string connectionString = @"Database=db_sistemaCliente;Server=BIANCA-PC\B1;user=sa;pwd=sap@123;";
        private const string providerName = @"System.Data.SqlClient";

        private IClienteRepositorio _repositorioCliente;
        private Cliente cliente;


        public FormInicial()
        {
            InitializeComponent();
        }

        public void FormInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemaClienteDataSet21.Cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter3.Fill(this.db_sistemaClienteDataSet21.Cliente);
            CarregaGrid();
        }

        public void CarregaGrid()
        {
            _repositorioCliente = new ClienteRepositorio(connectionString, providerName);

            dgdClientes.DataSource = _repositorioCliente.ObterTodos().ToList();
            TotalRegistros();
        }

        private void TotalRegistros()
        {
            var linhas = dgdClientes.RowCount;
            label2.Text = "Total de registros: " + linhas;
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            var form = new CadastroCliente(cliente);
            form.Show();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            ProcessarConsultaCliente(pesquisarClienteTextBox.Text);
        }

        public void ProcessarConsultaCliente(string filtroNomeProduto)
        {
            if (!String.IsNullOrWhiteSpace(filtroNomeProduto))
            {
                dgdClientes.DataSource = _repositorioCliente.ObterPesquisa(filtroNomeProduto.Trim()).ToList();
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            SelecionaCliente();
        }

        public void SelecionaCliente()
        {
            if (dgdClientes.CurrentRow != null)
                cliente = _repositorioCliente.ObterPor((int)dgdClientes.CurrentRow.Cells["columnCodigo"].Value);

            var form = new CadastroCliente(cliente);
            form.Show();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (dgdClientes.CurrentRow != null)
            {
                var mensagem = string.Format("Deseja excluir o contato: {0} ?", dgdClientes.CurrentRow.Cells["columnNome"].Value);

                if (MessageBox.Show(mensagem, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
                {
                    cliente = _repositorioCliente.ObterPor((int)dgdClientes.CurrentRow.Cells["columnCodigo"].Value);
                    _repositorioCliente.Excluir(cliente);

                    CarregaGrid();
                }
            }
          
            }
        }
    }

