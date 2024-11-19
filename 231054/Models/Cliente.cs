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
    internal class Cliente
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string uf { get; set; }

        public int idCidade { get; set; }
        public DateTime dataNasc { get; set; }

        public double renda { get; set; }

        public string cpf{ get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }
        public void Incluir()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a intrucao e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO clientes (nome, uf,idCidade,dataNasc,renda,cpf,foto,venda) VALUES(@nome,  @uf, @idCidade, @dataNasc, @renda, @cpf, @foto, @venda)", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome);//parametro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@ cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("Update cliente set nome = @nome, uf = @uf where id = @id", Banco.Conexao);
                // cria os parametros utilizados na instrucao SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome);//parametro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@ cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("delete from cliente where id = @id", Banco.Conexao);
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
                Banco.Comando = new MySqlCommand("SELECT * FROM cliente where nome like @nome " +
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
