using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaCliente.DI;

namespace SistemaCliente
{
    public partial class FormInicial : Form
    {
        private IClienteRepositorio _repositorio;
        private Cliente cliente;

        public FormInicial()
        {
            InitializeComponent();
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

        private void FormInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemaClienteDataSet4.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter2.Fill(this.db_sistemaClienteDataSet4.Cliente);

        }
        
        public void ProcessarNomePesquisado(string filtroNomeProduto)
        {
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
