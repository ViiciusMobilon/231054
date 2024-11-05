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
    public partial class Categoria : Form
    {
        Categoria a;
        public Categoria()
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
            DgvCategorias.DataSource = a.Consu();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
