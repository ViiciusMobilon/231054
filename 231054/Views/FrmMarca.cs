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
    public partial class FrmMarca : Form
    {
        Marca m;
        public FrmMarca()
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
            m = new Marca()
            {
                nome = pesquisa
            };
            DgMarcas.DataSource = m.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;
            m = new Marca()
            {
                nome = txtNome.Text,
            };

            m.Incluir();
            LimparControles();
            carregarGrid("");
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;
            m = new Marca()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
            };
            m.Alterar();
            LimparControles();
            carregarGrid("");
        }

        

        private void DgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgMarcas.RowCount > 0)
            {
                txtID.Text = DgMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = DgMarcas.CurrentRow.Cells["nome"].Value.ToString();
            }
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
                m = new Marca()
                {
                    id = int.Parse(txtID.Text)
                };
                m.Excluir();
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

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }
    }
}
