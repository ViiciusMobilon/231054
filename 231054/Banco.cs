using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _231054
{
    public class Banco
    {
        // criando as variaveis publicas para conexão e consulta e serão usadas em todo projeto 
        // connection responsavel para a conexão no MSQL

        public static MySqlConnection Conexao;
        // Command responsavel pelas intruções SQL a serem executadas
        public static MySqlCommand Comando;
        //adapter responsavel por inserir dados em um dataTable 
        public static MySqlDataAdapter Adaptador;
        //dataTable resposavel por ligar o banco em cotrole com a propriedade Datasource 
        public static DataTable dataTabela;
        public static void AbrirConexao()
        {
            try
            {
                // Estabelece os parametros para a conexao com o banco 
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                //abre a conexao com o banco de dados 
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                //fechar a conexao com o banco de dados 
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                //chamar a funcao para a abertura do banco de conexao com o banco
                AbrirConexao();

                // Informar a instrucao sql 
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                // executa a query no mysql (raio do Workbench)
                Comando.ExecuteNonQuery();

                Comando= new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades" +
                                           "(id integer auto_increment primary key," +
                                           "nome char(40)," +
                                           "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas" +
                                           "(id integer auto_increment primary key," +
                                           "nome char(40))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categoria" +
                                           "(id integer auto_increment primary key," +
                                           "nome char(40))", Conexao);
                
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes" +
                                           "(id integer auto_increment primary key," +
                                           "nome char(40))"+
                                           "idCidade interger"+
                                           "DataNasc date"+
                                           "renda decimal(10,2)"+
                                           "cpf char(14)"+
                                           "foto varchar(100)"+
                                           "venda boolean", Conexao);
                Comando.ExecuteNonQuery();
                // chama a funcao para fechar a conexão com o banco
                FecharConexao();
            }


            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
    
