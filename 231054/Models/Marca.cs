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
    
        public class Marca
        {
            public int id { get; set; }

            public string nome { get; set; }





            public void Incluir()
            {
                try
                {
                    // abre a conexao com o banco
                    Banco.AbrirConexao();
                    //alimenta o metodo command com a intrucao e indica a conexao utilizada
                    Banco.Comando = new MySqlCommand("INSERT INTO marcas (nome) VALUES(@nome)", Banco.Conexao);
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
            public void Alterar()
            {
                try
                {
                    // abre a conexao com o banco
                    Banco.AbrirConexao();
                    //alimenta o metodo command com a intrucao e indica a conexao utilizada
                    Banco.Comando = new MySqlCommand("Update marcas set nome = @nome where id = @id", Banco.Conexao);
                    // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                    Banco.Comando.Parameters.AddWithValue("@nome", nome);//parametro string
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
                    Banco.Comando = new MySqlCommand("delete from marcas where id = @id", Banco.Conexao);
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
                    Banco.AbrirConexao();
                    Banco.Comando = new MySqlCommand("SELECT * FROM marcas where nome like @nome " +
                                                                    "order by nome", Banco.Conexao);
                    Banco.Comando.Parameters.AddWithValue("@nome", nome + "%");
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

