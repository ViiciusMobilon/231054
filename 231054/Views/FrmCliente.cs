using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231054.Models;

namespace _231054.Models
{
    public partial class FrmCliente : Form
    {
        Cidade ci;
        Cliente cl;
        public FrmCliente()
        {
            InitializeComponent();
        }
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            DgvClientes.DataSource = cl.Consultar();
        }
        void LimparControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtuf.Clear();
            txtRenda.Clear();
            mskCPF.Clear();
            dtpDataNasc.Value= DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

       

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;
            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked,


            };
            cl.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtuf.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation= ofdArquivo.FileName;
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.Rows.Count > 0)
            {
                txtId.Text = DgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = DgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = DgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtuf.Text = DgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)DgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = DgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = DgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = DgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = DgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;
            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked,


            };
            cl.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            if (MessageBox.Show("Deseja excluir a cliete?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(txtId.Text)
                };
                cl.Excluir();
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

        private void FrmCliente_Load_1(object sender, EventArgs e)
        {
            
                // cria um objeto do tipo cidade
                // E alimenta o combobox
                ci = new Cidade();
                cboCidades.DataSource = ci.Consultar();
                cboCidades.DisplayMember = "nome";
                cboCidades.ValueMember = "id";

                LimparControles();
                carregarGrid("");
                // deixa invisivel colunas da grid

                DgvClientes.Columns["idCidade"].Visible = false;
                DgvClientes.Columns["foto"].Visible = false;
           
        }
    }
}
