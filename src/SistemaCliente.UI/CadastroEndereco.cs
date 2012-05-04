using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaCliente.DI;
using SistemaCliente.Infra;

namespace SistemaCliente
{
    public partial class CadastroEndereco : Form
    {
        private const string connectionString = @"Database=db_sistemaCliente;Server=BIANCA-PC\B1;user=sa;pwd=sap@123;";
        private const string providerName = @"System.Data.SqlClient";

        private readonly IClienteRepositorio _repositorioCliente = new ClienteRepositorio(connectionString, providerName);
        private readonly Cliente cliente = new Cliente();
        private readonly IEnderecoRepositorio _repositorioEndereco = new EnderecoRepositorio(connectionString, providerName);
        private readonly Endereco endereco = new Endereco();


        public CadastroEndereco(Endereco endereco)
        {
            InitializeComponent();
        }

        private void novoEnderecoButton_Click(object sender, EventArgs e)
        {
            //nomeClienteTextBox.Enabled = true;

            endereco.ClienteId = cliente.Id;
            endereco.Tipo = tipoEnderecoTextBox.Text;
            endereco.Nome = nomeEnderecoTextBox.Text;
            endereco.Bairro = bairroTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;

            endereco.ClienteId = _repositorioCliente.Inserir(cliente).Id;
            _repositorioEndereco.Inserir(endereco);

            //Salvar();
        }
    }
}
