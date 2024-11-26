using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231054.Models
{
   public class Produto
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public int idCliente { get; set; }

        public string idMarca { get; set; }

        public string estoque { get; set; }

        public string valorVenda { get; set; }

        public string foto { get; set; }

        public void Incluir()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a intrucao e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO produtos (descricao, idCategoria, idMarca, estoque, valorVenda, foto)"+"" +
                    " VALUES(@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome);//parametro string
                                                                     //executa o comandos , no MSQL tem a funcao do raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //fecha a conexao
                Banco.FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
