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
    public partial class FrmCategoria : Form
    {
        Categoria a;
        public FrmCategoria()
        {
            InitializeComponent();
        }




        void LimparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtpesquisar.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            a = new Categoria()
            {
                nome = pesquisa
            };
            DgvCategorias.DataSource = a.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;
            a = new Categoria()
            {
                nome = txtNome.Text,

            };

            a.Incluir();
            LimparControles();
            carregarGrid("");
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;
            a = new Categoria()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
            };
            a.Alterar();
            LimparControles();
            carregarGrid("");
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {

            LimparControles();
            carregarGrid("");
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                a = new Categoria()
                {
                    id = int.Parse(txtID.Text)
                };
                a.Excluir();
                LimparControles();
                carregarGrid("");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtpesquisar.Text);
        }

        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.RowCount > 0)
            {
                txtID.Text = DgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = DgvCategorias.CurrentRow.Cells["nome"].Value.ToString();
            }
        }
    }
}
