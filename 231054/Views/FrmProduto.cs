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
    public partial class FrmProduto : Form
    {
        Categoria ca;
        Marca ma;
        Produto pro;

        public FrmProduto()
        {
            InitializeComponent();
        }
        void carregarGrid(string pesquisa)
        {
            pro = new Produto()
            {
                descricao = pesquisa
            };
            Dgvproduto.DataSource = pro.Consultar();
        }

        void LimparControles()
        {
            txtId.Clear();
            txtDescricao.Clear();
            cbocategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            txtvenda.Clear();
            txtEstoque.Clear();
            picFoto.ImageLocation = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "") return;
            pro = new Produto()
            {
                descricao = txtDescricao.Text,
                idCategoria = (int)cbocategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valorVenda = double.Parse(txtvenda.Text),
                estoque = int.Parse(txtEstoque.Text),
                foto = picFoto.ImageLocation,
              


            };
            pro.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void cbocategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocategoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbocategoria.SelectedItem;
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboMarca.SelectedItem;
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void Dgvproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgvproduto.Rows.Count > 0)
            {
                txtId.Text = Dgvproduto.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = Dgvproduto.CurrentRow.Cells["descricao"].Value.ToString();
                cbocategoria.Text = Dgvproduto.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarca.Text = Dgvproduto.CurrentRow.Cells["marca"].Value.ToString();
                txtvenda.Text = Dgvproduto.CurrentRow.Cells["valorVenda"].Value.ToString();
                txtEstoque.Text = Dgvproduto.CurrentRow.Cells["estoque"].Value.ToString();

            }
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "") return;
            pro = new Produto()
            {
                descricao = txtDescricao.Text,
                idCategoria = (int)cbocategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valorVenda = double.Parse(txtvenda.Text),
                estoque = int.Parse(txtEstoque.Text),
                foto = picFoto.ImageLocation,


            };
            pro.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja excluir o produto?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pro = new Produto()
                {
                    id = int.Parse(txtId.Text)
                };
                pro.Excluir();
                LimparControles();
                carregarGrid("");

            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }

        private void bntPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtpesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // cria um objeto do tipo cidade
            // E alimenta o combobox
            ma = new Marca();
            cboMarca.DataSource = ma.Consultar();
            cboMarca.DisplayMember = "nome";
            cboMarca.ValueMember = "id";

            ca = new Categoria();
            cbocategoria.DataSource = ca.Consultar();
            cbocategoria.DisplayMember = "nome";
            cbocategoria.ValueMember = "id";
            LimparControles();
            carregarGrid("");
            // deixa invisivel colunas da grid

            Dgvproduto.Columns["idcategoria"].Visible = false;
            Dgvproduto.Columns["foto"].Visible = false;
        }
    }
    }

