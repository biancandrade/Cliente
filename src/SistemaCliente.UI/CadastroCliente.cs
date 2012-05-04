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
        private readonly Cliente cliente = new Cliente();
        private readonly IEnderecoRepositorio _repositorioEndereco = new EnderecoRepositorio(connectionString, providerName);
        private readonly Endereco endereco = new Endereco();


        public CadastroCliente(Cliente cliente)
        {
            InitializeComponent();

            if (cliente !=null)
            {
                nomeClienteTextBox.Text = cliente.Nome;
                nomeClienteTextBox.Enabled = false;
                enderecoDataGridView.DataSource = _repositorioEndereco.ObterTodos().ToList();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            Salvar();

            //this.Close();
        }

        private void Salvar()
        {
            if (nomeClienteTextBox.Text == "")
            {
                MessageBox.Show("Campo nulo! Informe um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (nomeClienteTextBox != null)
                {
                    cliente.Nome = nomeClienteTextBox.Text;
                    var data = DateTime.Now;
                    cliente.DataCadastro = data;
                    //endereco.Tipo = tipoEnderecoTextBox.Text;
                    //endereco.Nome = nomeEnderecoTextBox.Text;
                    //endereco.Bairro = bairroTextBox.Text;
                    //endereco.Cidade = cidadeTextBox.Text;

                    endereco.ClienteId = _repositorioCliente.Inserir(cliente).Id;
                    _repositorioEndereco.Inserir(endereco);

                    const string message = "Dados inseridos com sucesso!";
                    MessageBox.Show(message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var form = new FormInicial();
                    form.CarregaGrid();
                    this.Close();
                }
            }
        }

        
        

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemaClienteDataSet3.Endereco' table. You can move, or remove it, as needed.
            this.enderecoTableAdapter.Fill(this.db_sistemaClienteDataSet3.Endereco);

        }

        private void excluirEnderecoButton_Click(object sender, EventArgs e)
        {

        }

        private void novoEnderecoButton_Click(object sender, EventArgs e)
        {
            var form = new CadastroEndereco(endereco);
            form.Show();
        }
    }
}

