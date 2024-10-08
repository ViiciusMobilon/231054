namespace _231054.Views
{
    partial class FrmCidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.DgvCidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(536, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidades";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(554, 129);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(77, 20);
            this.txtUF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UF";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(16, 182);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(125, 61);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(147, 182);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(120, 61);
            this.bntAlterar.TabIndex = 7;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(273, 182);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(120, 61);
            this.bntCancelar.TabIndex = 8;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntcancelar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(399, 182);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(108, 61);
            this.bntExcluir.TabIndex = 9;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(513, 182);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 61);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Digite o nome da Cidade para Pesquisar";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(12, 277);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(536, 20);
            this.txtpesquisar.TabIndex = 12;
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.Location = new System.Drawing.Point(554, 255);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(97, 42);
            this.bntPesquisa.TabIndex = 13;
            this.bntPesquisa.Text = "Pesquisar";
            this.bntPesquisa.UseVisualStyleBackColor = true;
            this.bntPesquisa.Click += new System.EventHandler(this.bntpesquisa_Click);
            // 
            // DgvCidades
            // 
            this.DgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCidades.Location = new System.Drawing.Point(12, 304);
            this.DgvCidades.Name = "DgvCidades";
            this.DgvCidades.Size = new System.Drawing.Size(536, 134);
            this.DgvCidades.TabIndex = 14;
            this.DgvCidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCidades_CellClick);
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 566);
            this.ControlBox = false;
            this.Controls.Add(this.DgvCidades);
            this.Controls.Add(this.bntPesquisa);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.Load += new System.EventHandler(this.FrmCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.DataGridView DgvCidades;
    }
}