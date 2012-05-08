namespace SistemaCliente
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.excluirEnderecoButton = new System.Windows.Forms.Button();
            this.novoEnderecoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.enderecoDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaClienteDataSet3 = new SistemaCliente.db_sistemaClienteDataSet3();
            this.enderecoTableAdapter = new SistemaCliente.db_sistemaClienteDataSet3TableAdapters.EnderecoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // excluirEnderecoButton
            // 
            this.excluirEnderecoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirEnderecoButton.Location = new System.Drawing.Point(545, 261);
            this.excluirEnderecoButton.Name = "excluirEnderecoButton";
            this.excluirEnderecoButton.Size = new System.Drawing.Size(115, 26);
            this.excluirEnderecoButton.TabIndex = 29;
            this.excluirEnderecoButton.Text = "Excluir Endereço";
            this.excluirEnderecoButton.UseVisualStyleBackColor = true;
            this.excluirEnderecoButton.Click += new System.EventHandler(this.excluirEnderecoButton_Click);
            // 
            // novoEnderecoButton
            // 
            this.novoEnderecoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoEnderecoButton.Location = new System.Drawing.Point(402, 261);
            this.novoEnderecoButton.Name = "novoEnderecoButton";
            this.novoEnderecoButton.Size = new System.Drawing.Size(137, 26);
            this.novoEnderecoButton.TabIndex = 28;
            this.novoEnderecoButton.Text = "Adicionar Endereço";
            this.novoEnderecoButton.UseVisualStyleBackColor = true;
            this.novoEnderecoButton.Click += new System.EventHandler(this.novoEnderecoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(84, 25);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(355, 23);
            this.nomeClienteTextBox.TabIndex = 31;
            // 
            // enderecoDataGridView
            // 
            this.enderecoDataGridView.AllowUserToOrderColumns = true;
            this.enderecoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enderecoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enderecoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enderecoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.clienteIdDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn});
            this.enderecoDataGridView.DataSource = this.enderecoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enderecoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.enderecoDataGridView.Location = new System.Drawing.Point(12, 71);
            this.enderecoDataGridView.Name = "enderecoDataGridView";
            this.enderecoDataGridView.Size = new System.Drawing.Size(648, 150);
            this.enderecoDataGridView.TabIndex = 33;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataMember = "Endereco";
            this.enderecoBindingSource.DataSource = this.db_sistemaClienteDataSet3;
            // 
            // db_sistemaClienteDataSet3
            // 
            this.db_sistemaClienteDataSet3.DataSetName = "db_sistemaClienteDataSet3";
            this.db_sistemaClienteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoTableAdapter
            // 
            this.enderecoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 34;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enderecoDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excluirEnderecoButton);
            this.Controls.Add(this.novoEnderecoButton);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroCliente";
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excluirEnderecoButton;
        private System.Windows.Forms.Button novoEnderecoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.DataGridView enderecoDataGridView;
        private db_sistemaClienteDataSet3 db_sistemaClienteDataSet3;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private db_sistemaClienteDataSet3TableAdapters.EnderecoTableAdapter enderecoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
    }
}