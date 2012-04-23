namespace SistemaCliente
{
    partial class formCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaClienteDataSet = new SistemaCliente.db_sistemaClienteDataSet();
            this.clienteTableAdapter = new SistemaCliente.db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter();
            this.novoButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.codClienteTextBox = new System.Windows.Forms.TextBox();
            this.pesquisarLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data de Cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.Width = 130;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.db_sistemaClienteDataSet;
            // 
            // db_sistemaClienteDataSet
            // 
            this.db_sistemaClienteDataSet.DataSetName = "db_sistemaClienteDataSet";
            this.db_sistemaClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // novoButton
            // 
            this.novoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.novoButton.Location = new System.Drawing.Point(321, 279);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(77, 32);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            // 
            // editarButton
            // 
            this.editarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarButton.Location = new System.Drawing.Point(402, 279);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(77, 32);
            this.editarButton.TabIndex = 5;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excluirButton.Location = new System.Drawing.Point(483, 279);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(77, 32);
            this.excluirButton.TabIndex = 6;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarButton.Location = new System.Drawing.Point(564, 279);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(77, 32);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // codClienteTextBox
            // 
            this.codClienteTextBox.Location = new System.Drawing.Point(152, 31);
            this.codClienteTextBox.Name = "codClienteTextBox";
            this.codClienteTextBox.Size = new System.Drawing.Size(235, 20);
            this.codClienteTextBox.TabIndex = 9;
            // 
            // pesquisarLabel
            // 
            this.pesquisarLabel.AutoSize = true;
            this.pesquisarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.pesquisarLabel.Location = new System.Drawing.Point(17, 32);
            this.pesquisarLabel.Name = "pesquisarLabel";
            this.pesquisarLabel.Size = new System.Drawing.Size(130, 17);
            this.pesquisarLabel.TabIndex = 8;
            this.pesquisarLabel.Text = "Nome do cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codClienteTextBox);
            this.Controls.Add(this.pesquisarLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.formCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox codClienteTextBox;
        private System.Windows.Forms.Label pesquisarLabel;
        private System.Windows.Forms.Button button1;
    }
}

