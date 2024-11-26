using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int idCategoria { get; set; }

        public int idMarca { get; set; }

        public int estoque { get; set; }

        public double valorVenda { get; set; }

        public string foto { get; set; }

        public void Incluir()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a intrucao e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO produtos (descricao, idCategoria, idMarca, estoque, valorVenda, foto)" + "" +
                    " VALUES(@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);//parametro string
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);//executa o comandos , no MSQL tem a funcao do raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //fecha a conexao
                Banco.FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a intrucao e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("Update produtos set descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca, estoque = @estoque, valorVenda = @valorVenda, foto = @foto where id = @id", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);//parametro string
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);//parametro string
                Banco.Comando.Parameters.AddWithValue("@id", id);
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
        public void Excluir()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a intrucao e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("delete from produtos where id = @id", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@id", id);

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
        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT p.*, marcas, c.categoria FROM" +
                    " produtos p inner join marcas m on (m.id = p.idMarca)" +
                    " inner join categoria c on (c.id = p.idCategoria)" +
                    "where p.descricao like @descricao order by p.descricao ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.dataTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.dataTabela);
                Banco.FecharConexao();
                return Banco.dataTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }

    }
}
    
