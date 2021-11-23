using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Menu
    {
        string opcao;

        public string menu()
        {
            Console.WriteLine("Bem Vindo a Game Star");
            Console.WriteLine("1 - Ver Jogos");
            Console.WriteLine("2 - Ver Consoles");
            Console.WriteLine("3 - Ver Acessórios");
            Console.WriteLine("C - Cadastro");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("-------x-------");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }
        public string menuVendedor()
        {

            Console.WriteLine("Menu Cadastros");
            Console.WriteLine("----------x---------");
            Console.WriteLine("0 - Ver Clientes");
            Console.WriteLine("1 - Cadastrar Jogos");
            Console.WriteLine("2 - Cadartrar Consoles");
            Console.WriteLine("3 - Cadastrar Acessorios");
            Console.WriteLine("4 - Cadastrar Cliente");
            Console.WriteLine("------------Alterar Dados------------");
            Console.WriteLine("1.1 - Alterar dados Jogos");
            Console.WriteLine("2.1 - Alterar dados Consoles");
            Console.WriteLine("3.1 - Alterar dados Acessorios");
            Console.WriteLine("4.1 - Alterar dados Clientes");
            Console.WriteLine("------------------X------------------");
            Console.WriteLine("5 - Menu Principal");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }
    }
}
