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
            this.dgdClientes = new System.Windows.Forms.DataGridView();
            this.db_sistemaClienteDataSet5 = new SistemaCliente.db_sistemaClienteDataSet();
            this.clienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new SistemaCliente.db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).BeginInit();
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
            this.novoButton.Location = new System.Drawing.Point(321, 279);
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
            // dgdClientes
            // 
            this.dgdClientes.AutoGenerateColumns = false;
            this.dgdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgdClientes.DataSource = this.clienteBindingSource4;
            this.dgdClientes.Location = new System.Drawing.Point(57, 66);
            this.dgdClientes.Name = "dgdClientes";
            this.dgdClientes.Size = new System.Drawing.Size(447, 150);
            this.dgdClientes.TabIndex = 11;
            // 
            // db_sistemaClienteDataSet5
            // 
            this.db_sistemaClienteDataSet5.DataSetName = "db_sistemaClienteDataSet";
            this.db_sistemaClienteDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource4
            // 
            this.clienteBindingSource4.DataMember = "Cliente";
            this.clienteBindingSource4.DataSource = this.db_sistemaClienteDataSet5;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataCadastro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdClientes);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.pesquisarClienteTextBox);
            this.Controls.Add(this.pesquisarLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Name = "FormInicial";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaClienteDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).EndInit();
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
        private System.Windows.Forms.DataGridView dgdClientes;
        private db_sistemaClienteDataSet db_sistemaClienteDataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource4;
        private db_sistemaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

