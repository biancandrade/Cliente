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
        private static string connectionString = @"Database=db_sistemaCliente;Server=BIANCA-PC\B1;user=sa;pwd=sap@123;";
        private static string providerName = @"System.Data.SqlClient";

        private IClienteRepositorio _repositorio = new ClienteRepositorio(connectionString, providerName);
        private readonly Cliente cliente = new Cliente();


        public CadastroCliente()
        {
            InitializeComponent();
        }
        

        private void salvarButton_Click(object sender, EventArgs e)
        {
            cliente.Nome = nomeClienteTextBox.Text;
            
            cliente.DataCadastro = (DateTime.Now.Date);

            _repositorio.Inserir(cliente);
        }
    }
}
