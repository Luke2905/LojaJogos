using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LojaJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Menus-----------------
            string opcao;
            Menu menu = new Menu();
            Menu menuven = new Menu();
            //---------------FIM---------------
            //---------Conexão-----------------
            Conexao dao = new Conexao();
            Conexao2 dao2 = new Conexao2();
            JogosDB jogosdb = new JogosDB();
            ConsolesDB consolesdb = new ConsolesDB();
            //----------Metodo Jogos-----------------
            int i;
            string valorstring;


            //------------Metodo Consoles-------------
            /*Consoles[] console = new Consoles[4];

            console[0] = new Consoles();
            console[0].nome = "Xbox";
            console[0].tamanho_memoria = 250;
            console[0].preço = 5000.00;
            console[0].tipo = "Console de Mesa";
            console[0].marca = "Microsoft";*/
            //----------------FIM-----------------

            //----------------------PROGRAMA----------------------
            opcao = menu.menu();
            do {
                switch (opcao)
                {
                    //----------------------Menu Clientes----------------------
                            case "1":
                                Console.WriteLine("Lista de Jogos");
                                dao.listaJogos();
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menu.menu();
                                break;
                            case "2":
                                Console.WriteLine("Lista de Consoles");
                        dao2.listaConsoles();
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menu.menu();
                                break;
                    //----------------------FiM CLIENTE----------------------

                    //----------------------MENU VENDEDOR----------------------
                    case "C":
                        opcao = menuven.menuVendedor();
                        if (opcao == "1")
                        {
                            Console.WriteLine("     Tela de Cadastro de Jogos");
                            jogosdb.CadastrarJogo();
                            dao.inserirJogo(jogosdb);
                            Console.ReadKey();
                            Console.Clear();
                            opcao = menuven.menuVendedor();
                            //----------------------FIM----------------------
                        }if(opcao == "2") {
                            //----------------------CADASTRO CONSOLES----------------------
                            Console.WriteLine("     Tela de Cadastro de Consoles");
                            consolesdb.CadastrarConsoles();
                            dao2.inserirConsoles(consolesdb);
                            Console.ReadKey();
                            Console.Clear();
                            opcao = menuven.menuVendedor();
                            //----------------------FIM----------------------
                        }if(opcao == "1.1")
                        {
                            //----------------------ALTERAÇÃO DADOS JOGOS----------------------
                            Console.WriteLine("Menu de Alteração de Dados dos Jogos");
                            Console.WriteLine("Informe o Numero do Jogo - 0, 1, 2, 3");
                            valorstring = Console.ReadLine();
                            i = int.Parse(valorstring);
                           // jogo[i].AlterarJogos();

                            Console.ReadKey();
                            Console.Clear();
                            opcao = menu.menu();
                            //----------------------FIM----------------------
                        }if(opcao == "2.1")
                        {
                            //----------------------ALTERAÇÃO DADOS CONSOLES----------------------
                            Console.WriteLine("Menu de Alteração de Dados dos Consoles");
                            Console.WriteLine("Informe o Numero do Console - 0, 1, 2, 3");
                            valorstring = Console.ReadLine();
                            i = int.Parse(valorstring);
                            //console[i].AlterarConsoles();

                            Console.ReadKey();
                            Console.Clear();
                            opcao = menu.menu();
                            //----------------------FIM----------------------
                        }
                        break;
                    //----------------------FiM VENDEDOR----------------------
                    case "5":
                        Console.Clear();
                        opcao = menu.menu();
                        break;
                    default:
                        Console.WriteLine("Opcao invilida");
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menu();
                        break;
                }
                //----------------------FiM ----------------------
            } while (opcao != "6");
            Console.WriteLine("Fechando programa...");
            Console.ReadKey();


        }
    }
}
