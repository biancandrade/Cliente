﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCliente
{
    public partial class FormInicial : Form
    {

        public FormInicial()
        {
            InitializeComponent();
        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sistemaClienteDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.db_sistemaClienteDataSet.Cliente);

        }
    }
}
