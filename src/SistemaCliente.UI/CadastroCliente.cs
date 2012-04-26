using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaCliente;
using SistemaCliente.DI;
using SistemaCliente.Infra;

namespace SistemaCliente
{
    public partial class CadastroCliente : Form
    {
        private static string connectionString = @"Database=db_sistemaCliente;Server=USUARIO-PC\APP;user=sa;pwd=sap@123;";
        private static string providerName = @"System.Data.SqlClient";

        private IClienteRepositorio _repositorio = new ClienteRepositorio(connectionString, providerName);
        private readonly Cliente cliente = new Cliente();


        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            cliente.Id = Convert.ToInt32(codClienteTextBox.Text);
            cliente.Nome = nomeClienteTextBox.Text;
            //var data = Convert.ToDateTime(dataLabel.Text);
            //data = new DateTime(2012, 04, 25);

            //cliente.DataCadastro = Convert.ToDateTime(dataLabel.Text);

            _repositorio.Inserir(cliente);
            
                var message = "Cadastro inserido com sucesso!";
                MessageBox.Show(message,"Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            var form = new FormInicial();
            form.Show();

            }

        public void CarregaGrid()
        {

            
        }

    }
    }

