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

        private readonly IEnderecoRepositorio _repositorioEndereco = new EnderecoRepositorio(connectionString, providerName);
        private readonly Endereco endereco;
        private Cliente cliente;

        public CadastroEndereco(Endereco endereco)
        {
            InitializeComponent();
            this.endereco = endereco;
        }

        private void inserirEnderecoButton_Click(object sender, EventArgs e)
        {
            endereco.Tipo = tipoEnderecoTextBox.Text;
            endereco.Nome = nomeEnderecoTextBox.Text;
            endereco.Bairro = bairroTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;

            _repositorioEndereco.Inserir(endereco);

            const string message = "Endereço inserido com sucesso!";
            MessageBox.Show(message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
