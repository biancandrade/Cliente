using System;
using System.Linq;
using System.Windows.Forms;
using SistemaCliente.DI;
using SistemaCliente.Infra;

namespace SistemaCliente
{
    public partial class CadastroCliente : Form
    {
        private const string connectionString = @"Database=db_sistemaCliente;Server=BIANCA-PC\B1;user=sa;pwd=sap@123;";
        private const string providerName = @"System.Data.SqlClient";

        private readonly IClienteRepositorio _repositorioCliente = new ClienteRepositorio(connectionString, providerName);
        private Cliente cliente;
        private readonly IEnderecoRepositorio _repositorioEndereco = new EnderecoRepositorio(connectionString,providerName);
        private Endereco endereco;

        public CadastroCliente(Cliente cliente)
        {
            InitializeComponent();
            ModoEditavel(cliente);
            this.cliente = cliente;
            TotalRegistros();
        }

        private void ModoEditavel(Cliente _cliente)
        {
            if (_cliente != null)
            {
                nomeClienteTextBox.Text = _cliente.Nome;
                nomeClienteTextBox.Enabled = false;
                enderecoDataGridView.DataSource = _repositorioEndereco.ObterPor(_cliente.Id).ToList();
            }
            else
            {
                nomeClienteTextBox.Enabled = true;
                enderecoDataGridView.DataSource = new object();
            }
        }

        private void TotalRegistros()
        {
            var linhas = enderecoDataGridView.RowCount;
            label1.Text = "Total de registros: " + linhas;
        }


        private void excluirEnderecoButton_Click(object sender, EventArgs e)
        {

        }

        private void novoEnderecoButton_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                endereco = new Endereco();
                endereco.ClienteId = cliente.Id;
            }

            else
            {
                SalvarCliente();
            }
            
            var form = new CadastroEndereco(endereco);
            form.Show();
        }

        private void SalvarCliente()
        {
            if (nomeClienteTextBox.Text == "")
            {
                MessageBox.Show("Campo nulo! Informe um cliente!", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                if (nomeClienteTextBox != null)
                {
                    cliente = new Cliente();
                    endereco = new Endereco();

                    cliente.Nome = nomeClienteTextBox.Text;
                    var data = DateTime.Now;
                    cliente.DataCadastro = data;

                    endereco.ClienteId = _repositorioCliente.Inserir(cliente).Id;

                    const string message = "Cliente inserido com sucesso! Informe seu(s) endereço(s)!!";
                    MessageBox.Show(message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

