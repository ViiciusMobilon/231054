using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dtoDataNasc.Value= DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // cria um objeto do tipo cidade
            // E alimenta o combobox
            ci = new Cidade();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            LimparControles();
            carregarGrid("");
            // deixa invisivel colunas da grid

            DgvClientes.Columns["idCidade"].Visible = false;
            DgvClientes.Columns["foto"].Visible=false;


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if 
        }
    }
}
