﻿using System;
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

            Console.WriteLine("Game Store");
            Console.WriteLine("Acessar a Loja como:");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("-------x-------");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }

        public string menuCliente()
        {

            Console.WriteLine("-------x-------");
            Console.WriteLine("1 - Ver Jogos");
            Console.WriteLine("2 - Ver Consoles");
            Console.WriteLine("5 - Menu Principal");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }

        public string menuVendedor()
        {

            Console.WriteLine("-------x-------");
            Console.WriteLine("0 - Ver Clientes");
            Console.WriteLine("1 - Cadastrar Jogos");
            Console.WriteLine("2 - Cadartrar Consoles");
            Console.WriteLine("3 - Cadastrar Acessorios");
            Console.WriteLine("4 - Cadastrar Cliente");
            Console.WriteLine("5 - Menu Principal");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }
    }
}
