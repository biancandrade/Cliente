namespace SistemaCliente
{
    partial class FormInicial
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novoButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.pesquisarClienteTextBox = new System.Windows.Forms.TextBox();
            this.pesquisarLabel = new System.Windows.Forms.Label();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaClienteDataSet5 = new SistemaCliente.db_sistemaClienteDataSet();
            this.clienteTableAdapter1 = new SistemaCliente.db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.db_sistemaClienteDataSet21 = new SistemaCliente.db_sistemaClienteDataSet2();
            this.clienteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter3 = new SistemaCliente.db_sistemaClienteDataSet2TableAdapters.ClienteTableAdapter();
            this.dbsistemaClienteDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgdClientes = new System.Windows.Forms.DataGridView();
            this.columnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaClienteDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            // 
            // novoButton
            // 
            this.novoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.novoButton.Location = new System.Drawing.Point(198, 322);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(77, 32);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarButton.Location = new System.Drawing.Point(279, 322);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(77, 32);
            this.editarButton.TabIndex = 5;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excluirButton.Location = new System.Drawing.Point(360, 322);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(77, 32);
            this.excluirButton.TabIndex = 6;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarButton.Location = new System.Drawing.Point(441, 322);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(77, 32);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // pesquisarClienteTextBox
            // 
            this.pesquisarClienteTextBox.Location = new System.Drawing.Point(152, 31);
            this.pesquisarClienteTextBox.Name = "pesquisarClienteTextBox";
            this.pesquisarClienteTextBox.Size = new System.Drawing.Size(235, 20);
            this.pesquisarClienteTextBox.TabIndex = 9;
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
            // pesquisarButton
            // 
            this.pesquisarButton.Location = new System.Drawing.Point(393, 31);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(86, 21);
            this.pesquisarButton.TabIndex = 10;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // clienteBindingSource4
            // 
            this.clienteBindingSource4.DataMember = "Cliente";
            this.clienteBindingSource4.DataSource = this.db_sistemaClienteDataSet5;
            // 
            // db_sistemaClienteDataSet5
            // 
            this.db_sistemaClienteDataSet5.DataSetName = "db_sistemaClienteDataSet";
            this.db_sistemaClienteDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(17, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // db_sistemaClienteDataSet21
            // 
            this.db_sistemaClienteDataSet21.DataSetName = "db_sistemaClienteDataSet2";
            this.db_sistemaClienteDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource5
            // 
            this.clienteBindingSource5.DataMember = "Cliente";
            this.clienteBindingSource5.DataSource = this.db_sistemaClienteDataSet21;
            // 
            // clienteTableAdapter3
            // 
            this.clienteTableAdapter3.ClearBeforeFill = true;
            // 
            // dbsistemaClienteDataSet5BindingSource
            // 
            this.dbsistemaClienteDataSet5BindingSource.DataSource = this.db_sistemaClienteDataSet5;
            this.dbsistemaClienteDataSet5BindingSource.Position = 0;
            // 
            // dgdClientes
            // 
            this.dgdClientes.AutoGenerateColumns = false;
            this.dgdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCodigo,
            this.columnNome,
            this.columnDataCadastro});
            this.dgdClientes.DataSource = this.clienteBindingSource5;
            this.dgdClientes.Location = new System.Drawing.Point(12, 86);
            this.dgdClientes.Name = "dgdClientes";
            this.dgdClientes.Size = new System.Drawing.Size(506, 182);
            this.dgdClientes.TabIndex = 14;
            // 
            // columnCodigo
            // 
            this.columnCodigo.DataPropertyName = "Id";
            this.columnCodigo.HeaderText = "Codigo";
            this.columnCodigo.Name = "columnCodigo";
            this.columnCodigo.ReadOnly = true;
            // 
            // columnNome
            // 
            this.columnNome.DataPropertyName = "Nome";
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            // 
            // columnDataCadastro
            // 
            this.columnDataCadastro.DataPropertyName = "DataCadastro";
            this.columnDataCadastro.HeaderText = "DataCadastro";
            this.columnDataCadastro.Name = "columnDataCadastro";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 375);
            this.Controls.Add(this.dgdClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.pesquisarClienteTextBox);
            this.Controls.Add(this.pesquisarLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Name = "FormInicial";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaClienteDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_sistemaClienteDataSet db_sistemaClienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox pesquisarClienteTextBox;
        private System.Windows.Forms.Label pesquisarLabel;
        private System.Windows.Forms.Button pesquisarButton;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet1;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet3;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet4;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter2;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource4;
        private db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.Label label2;
        private db_sistemaClienteDataSet2 db_sistemaClienteDataSet21;
        private System.Windows.Forms.BindingSource clienteBindingSource5;
        private db_sistemaClienteDataSet2TableAdapters.ClienteTableAdapter clienteTableAdapter3;
        private System.Windows.Forms.BindingSource dbsistemaClienteDataSet5BindingSource;
        private System.Windows.Forms.DataGridView dgdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataCadastro;
    }
}

