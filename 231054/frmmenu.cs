using _231054.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231054.Views;
using _231054.Models;


namespace _231054
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades form = new FrmCidades();
            form.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca form = new FrmMarca();
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria form = new FrmCategoria();
            form.Show();
        }
    }
}
