﻿namespace SistemaCliente
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
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeClienteLabel.Location = new System.Drawing.Point(16, 34);
            this.nomeClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeClienteLabel.TabIndex = 0;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(101, 31);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(325, 23);
            this.nomeClienteTextBox.TabIndex = 1;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(99, 146);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(225, 23);
            this.bairroTextBox.TabIndex = 2;
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bairroLabel.Location = new System.Drawing.Point(16, 150);
            this.bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(46, 17);
            this.bairroLabel.TabIndex = 3;
            this.bairroLabel.Text = "Bairro";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cidadeLabel.Location = new System.Drawing.Point(16, 187);
            this.cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(56, 17);
            this.cidadeLabel.TabIndex = 5;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(99, 183);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(225, 23);
            this.cidadeTextBox.TabIndex = 4;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoLabel.Location = new System.Drawing.Point(16, 74);
            this.tipoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(40, 17);
            this.tipoLabel.TabIndex = 7;
            this.tipoLabel.Text = "Tipo:";
            this.tipoLabel.Click += new System.EventHandler(this.tipoLabel_Click);
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.Location = new System.Drawing.Point(99, 70);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(225, 23);
            this.tipoTextBox.TabIndex = 6;
            this.tipoTextBox.TextChanged += new System.EventHandler(this.tipoTextBox_TextChanged);
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enderecoLabel.Location = new System.Drawing.Point(16, 112);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(73, 17);
            this.enderecoLabel.TabIndex = 9;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(99, 108);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(327, 23);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 253);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.nomeClienteLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.TextBox enderecoTextBox;
    }
}