using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LojaJogos
{
    class Conexao
    {
        public MySqlConnection conexao;
        public MySqlCommand cmd;
        public MySqlDataReader resultado;

        public Conexao()
        {
            conexao = new MySqlConnection("server=localhost;database=gamestar;uid=root; password=nega2029");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado");
            }

            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }
        }

        public void inserirJogo(JogosDB jg)
        {
            string sql = "insert into jogos (nome, genero, classificacao, preco) values (@nome,@genero,@faixa_etaria,@preco)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", jg.nome);
            cmd.Parameters.AddWithValue("@genero", jg.genero);
            cmd.Parameters.AddWithValue("@faixa_etaria", jg.faixa_etaria);
            cmd.Parameters.AddWithValue("@preco", jg.preco);
            cmd.ExecuteNonQuery();
        }

        public void listaJogos()
        {
            string sql = "select *from jogos";
            cmd = new MySqlCommand(sql, conexao);
            cmd.CommandText = sql;
            if(conexao.State == ConnectionState.Open)
            {

            }
            else
            {
                conexao.Open();
            }
            resultado = cmd.ExecuteReader();

            while (resultado.Read())
            {
                Console.WriteLine("-------x-------");
                Console.WriteLine("Nome: " + resultado["nome"]);
                Console.WriteLine("Genero: " + resultado["genero"]);
                Console.WriteLine("Classificação Etária: " + resultado["classificacao"]);
                Console.WriteLine("Preço: R$ " + resultado["preco"]);
            }
            conexao.Close();
        }
    }
}
