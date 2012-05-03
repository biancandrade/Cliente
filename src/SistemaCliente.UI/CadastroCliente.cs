﻿using System;
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


        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            cliente.Nome = nomeClienteTextBox.Text;
            dataTextBox.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            cliente.DataCadastro = Convert.ToDateTime(dataTextBox.Text);

            endereco.Tipo = tipoEnderecoTextBox.Text;
            endereco.Nome = nomeEnderecoTextBox.Text;
            endereco.Bairro = bairroTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;

            endereco.ClienteId = _repositorioCliente.Inserir(cliente).Id;
            _repositorioEndereco.Inserir(endereco);

            var message = "Dados inseridos com sucesso!";
            MessageBox.Show(message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}

