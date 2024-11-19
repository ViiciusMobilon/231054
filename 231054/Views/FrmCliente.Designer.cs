namespace _231054.Models
{
    partial class FrmCliente
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
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cboCidades = new System.Windows.Forms.ComboBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtoDataNasc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(81, 531);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(536, 134);
            this.DgvClientes.TabIndex = 42;
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.Location = new System.Drawing.Point(623, 482);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(97, 42);
            this.bntPesquisa.TabIndex = 41;
            this.bntPesquisa.Text = "Pesquisar";
            this.bntPesquisa.UseVisualStyleBackColor = true;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(81, 504);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(536, 20);
            this.txtpesquisar.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Digite o nome da Cidade para Pesquisar";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(582, 409);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 61);
            this.btnFechar.TabIndex = 38;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(468, 409);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(108, 61);
            this.bntExcluir.TabIndex = 37;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(342, 409);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(120, 61);
            this.bntCancelar.TabIndex = 36;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(216, 409);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(120, 61);
            this.bntAlterar.TabIndex = 35;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(85, 409);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(125, 61);
            this.btnIncluir.TabIndex = 34;
            this.btnIncluir.Text = "incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(510, 20);
            this.txtNome.TabIndex = 32;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(513, 168);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(78, 20);
            this.txtuf.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "uf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cidade";
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(382, 43);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(109, 17);
            this.chkVenda.TabIndex = 47;
            this.chkVenda.Text = "Bloqueia a venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(597, 20);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(205, 207);
            this.picFoto.TabIndex = 49;
            this.picFoto.TabStop = false;
            // 
            // cboCidades
            // 
            this.cboCidades.FormattingEnabled = true;
            this.cboCidades.Location = new System.Drawing.Point(81, 167);
            this.cboCidades.Name = "cboCidades";
            this.cboCidades.Size = new System.Drawing.Size(426, 21);
            this.cboCidades.TabIndex = 50;
            this.cboCidades.SelectedIndexChanged += new System.EventHandler(this.cboCidades_SelectedIndexChanged);
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(597, 265);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(100, 20);
            this.txtRenda.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Renda";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(81, 235);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(129, 20);
            this.mskCPF.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "CPF";
            // 
            // dtoDataNasc
            // 
            this.dtoDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtoDataNasc.Location = new System.Drawing.Point(247, 235);
            this.dtoDataNasc.Name = "dtoDataNasc";
            this.dtoDataNasc.Size = new System.Drawing.Size(200, 20);
            this.dtoDataNasc.TabIndex = 56;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.dtoDataNasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCidades);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.bntPesquisa);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmCliente";
            this.Text = "Clieante";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cboCidades;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtoDataNasc;
    }
}