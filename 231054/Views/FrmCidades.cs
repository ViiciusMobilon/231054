using _231054.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231054.Views
{
    public partial class FrmCidades : Form
    {
        Cidade c;
        public FrmCidades()
        {
            InitializeComponent();
        }
        void LimparControles()
        {
            txtID.Clear();
            txtnome.Clear();
            txtpesquisar.Clear();
            txtUF.Clear();
        }
        private void bntcancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }
        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            DgvCidades.DataSource = c.Consultar();
        }

        private void bntpesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtpesquisar.Text);
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == string.Empty) return;
            c = new Cidade()
            {
                nome = txtnome.Text,
               uf = txtUF.Text
            };

            c.Incluir();
            LimparControles();
            carregarGrid("");
        }

        private void DgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCidades.RowCount > 0) 
            {
             txtUF.Text = DgvCidades.CurrentRow.Cells["id"].Value.ToString();
             txtnome.Text = DgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = DgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void bntalterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;
            c = new Cidade()
            {
                id = int.Parse(txtID.Text),
                nome = txtnome.Text,
                uf = txtUF.Text
            };
            c.Alterar();
            LimparControles();
            carregarGrid("");
        }

        private void bntexcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(txtID.Text)
                };
                c.Excluir();
                LimparControles();
                carregarGrid("");
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
