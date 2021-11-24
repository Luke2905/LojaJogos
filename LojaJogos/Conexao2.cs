using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace LojaJogos
{
    class Conexao2
    {

        public MySqlConnection conexao;
        public MySqlCommand cmd;
        public MySqlDataReader resultado;

        public Conexao2()
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

        public void inserirConsoles(ConsolesDB cs)
        {
            string sql = "insert into jogos (nome, genero, preco) values (@nome,@marca,@preco)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cs.nome);
            cmd.Parameters.AddWithValue("@marca", cs.nome);
            cmd.Parameters.AddWithValue("@preco", cs.preço);
            cmd.ExecuteNonQuery();
        }

        public void listaConsoles()
        {
            string sql = "select *from consoles";
            cmd = new MySqlCommand(sql, conexao);
            cmd.CommandText = sql;
            if (conexao.State == ConnectionState.Open)
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
                Console.WriteLine("Marca: " + resultado["marca"]);
                Console.WriteLine("Preço: R$ " + resultado["preco"]);
            }
            conexao.Close();
        }


    }
}

