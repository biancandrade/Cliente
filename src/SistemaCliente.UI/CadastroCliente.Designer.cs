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
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoEnderecoLabel = new System.Windows.Forms.Label();
            this.tipoEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeEnderecoLabel = new System.Windows.Forms.Label();
            this.nomeEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.novoEnderecoButton = new System.Windows.Forms.Button();
            this.excluirEnderecoButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeClienteLabel.Location = new System.Drawing.Point(21, 29);
            this.nomeClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeClienteLabel.TabIndex = 0;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(78, 26);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(515, 23);
            this.nomeClienteTextBox.TabIndex = 2;
            // 
            // salvarButton
            // 
            this.salvarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.Location = new System.Drawing.Point(502, 367);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(97, 31);
            this.salvarButton.TabIndex = 10;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.excluirEnderecoButton);
            this.groupBox1.Controls.Add(this.novoEnderecoButton);
            this.groupBox1.Controls.Add(this.tipoEnderecoLabel);
            this.groupBox1.Controls.Add(this.tipoEnderecoTextBox);
            this.groupBox1.Controls.Add(this.nomeEnderecoLabel);
            this.groupBox1.Controls.Add(this.nomeEnderecoTextBox);
            this.groupBox1.Controls.Add(this.cidadeLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(this.bairroLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 259);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // tipoEnderecoLabel
            // 
            this.tipoEnderecoLabel.AutoSize = true;
            this.tipoEnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoEnderecoLabel.Location = new System.Drawing.Point(40, 51);
            this.tipoEnderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoEnderecoLabel.Name = "tipoEnderecoLabel";
            this.tipoEnderecoLabel.Size = new System.Drawing.Size(40, 17);
            this.tipoEnderecoLabel.TabIndex = 27;
            this.tipoEnderecoLabel.Text = "Tipo:";
            // 
            // tipoEnderecoTextBox
            // 
            this.tipoEnderecoTextBox.Location = new System.Drawing.Point(105, 47);
            this.tipoEnderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoEnderecoTextBox.Name = "tipoEnderecoTextBox";
            this.tipoEnderecoTextBox.Size = new System.Drawing.Size(327, 23);
            this.tipoEnderecoTextBox.TabIndex = 22;
            // 
            // nomeEnderecoLabel
            // 
            this.nomeEnderecoLabel.AutoSize = true;
            this.nomeEnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeEnderecoLabel.Location = new System.Drawing.Point(31, 82);
            this.nomeEnderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEnderecoLabel.Name = "nomeEnderecoLabel";
            this.nomeEnderecoLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeEnderecoLabel.TabIndex = 26;
            this.nomeEnderecoLabel.Text = "Nome:";
            // 
            // nomeEnderecoTextBox
            // 
            this.nomeEnderecoTextBox.Location = new System.Drawing.Point(107, 78);
            this.nomeEnderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeEnderecoTextBox.Name = "nomeEnderecoTextBox";
            this.nomeEnderecoTextBox.Size = new System.Drawing.Size(327, 23);
            this.nomeEnderecoTextBox.TabIndex = 23;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cidadeLabel.Location = new System.Drawing.Point(24, 142);
            this.cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(56, 17);
            this.cidadeLabel.TabIndex = 21;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(107, 138);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(325, 23);
            this.cidadeTextBox.TabIndex = 25;
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bairroLabel.Location = new System.Drawing.Point(30, 112);
            this.bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(50, 17);
            this.bairroLabel.TabIndex = 20;
            this.bairroLabel.Text = "Bairro:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(107, 108);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(325, 23);
            this.bairroTextBox.TabIndex = 24;
            // 
            // novoEnderecoButton
            // 
            this.novoEnderecoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoEnderecoButton.Location = new System.Drawing.Point(309, 196);
            this.novoEnderecoButton.Name = "novoEnderecoButton";
            this.novoEnderecoButton.Size = new System.Drawing.Size(82, 26);
            this.novoEnderecoButton.TabIndex = 28;
            this.novoEnderecoButton.Text = "Novo";
            this.novoEnderecoButton.UseVisualStyleBackColor = true;
            this.novoEnderecoButton.Click += new System.EventHandler(this.novoEnderecoButton_Click);
            // 
            // excluirEnderecoButton
            // 
            this.excluirEnderecoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirEnderecoButton.Location = new System.Drawing.Point(394, 196);
            this.excluirEnderecoButton.Name = "excluirEnderecoButton";
            this.excluirEnderecoButton.Size = new System.Drawing.Size(82, 26);
            this.excluirEnderecoButton.TabIndex = 29;
            this.excluirEnderecoButton.Text = "Excluir";
            this.excluirEnderecoButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(480, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.nomeClienteLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button excluirEnderecoButton;
        private System.Windows.Forms.Button novoEnderecoButton;
        private System.Windows.Forms.Label tipoEnderecoLabel;
        private System.Windows.Forms.TextBox tipoEnderecoTextBox;
        private System.Windows.Forms.Label nomeEnderecoLabel;
        private System.Windows.Forms.TextBox nomeEnderecoTextBox;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.TextBox bairroTextBox;
    }
}