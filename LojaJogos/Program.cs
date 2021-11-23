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
            JogosDB jogosdb = new JogosDB();
            //----------Metodo Jogos-----------------
            int i;
            string valorstring;
            // Jogos[] jogo = new Jogos [4];

           /* jogo[0] = new Jogos();
            jogo[0].nome = "GTA";
            jogo[0].genero = "Sandbox";
            jogo[0].faixa_etaria = "18";
            jogo[0].estudio = "Rockstar Games";
            jogo[0].preco = 250.00;*/
            //---------------FIM---------------


            //------------Metodo Consoles-------------
            Consoles[] console = new Consoles[4];

            console[0] = new Consoles();
            console[0].nome = "Xbox";
            console[0].tamanho_memoria = 250;
            console[0].preço = 5000.00;
            console[0].tipo = "Console de Mesa";
            console[0].marca = "Microsoft";
            //----------------FIM---------------------

            //------------Metodo Acessorios-------------
            Acessorios[] acessorio = new Acessorios[4];

            acessorio[0] = new Acessorios();
            acessorio[0].nome = "Fone de Ouvido";
            acessorio[0].marca = "sony";
            acessorio[0].console = "playstation";
            acessorio[0].preco = 150.00;
            //----------------FIM---------------------

            //---------------Metodo Cliente---------------
            Clientes[] cadastro = new Clientes[4];

            cadastro[0] = new Clientes();
            cadastro[0].nome = "Lucas";
            cadastro[0].cpf = "000.000.000.-00";
            cadastro[0].dia = 29;
            cadastro[0].mes = 05;
            cadastro[0].ano = 2002;
            cadastro[0].endereco = "Rua Fulano da tal, 321 - Dadema/SP";
            cadastro[0].email = "lucas@gmail.com";
            //---------------FIM---------------

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
                                for (i = 0; i < 4; i++)
                                {
                                    console[i].ListaConsoles();
                                }
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menu.menu();
                                break;
                            case "3":
                                Console.WriteLine("Lista de Acessórios");
                                for (i = 0; i < 4; i++)
                                {
                                    acessorio[i].ListaAcessorios();
                                }
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menu.menu();
                                break;
                    //----------------------FiM CLIENTE----------------------

                    //----------------------MENU VENDEDOR----------------------
                    case "C":
                        opcao = menuven.menuVendedor();
                        if(opcao == "0") {
                            Console.WriteLine("Lista de Clientes");
                            for (i = 0; i < 4; i++)
                            {
                                cadastro[i].ListaDados();
                            }
                            Console.ReadKey();
                            Console.Clear();
                            opcao = menuven.menuVendedor();
                            //----------------------CADASTRO JOGOS----------------------
                        }
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
                            for (i = 0; i < 4; i++)
                            {
                                console[i] = new Consoles();
                            }
                            for (i = 0; i < 4; i++)
                            {
                                Console.WriteLine("Digite o nome do console:");
                                console[i].nome = Console.ReadLine();
                                Console.WriteLine("Memoria Interna do Console:");
                                valorstring = Console.ReadLine();
                                console[i].tamanho_memoria = int.Parse(valorstring);
                                Console.WriteLine("Preço");
                                valorstring = Console.ReadLine();
                                console[i].preço = double.Parse(valorstring);
                                Console.WriteLine("Informe o tipo do console (de mesa ou portatil): ");
                                console[i].marca = Console.ReadLine();
                                Console.WriteLine("Informe a marca do console:");
                                console[i].marca = Console.ReadLine();
                            }
                            Console.ReadKey();
                            Console.Clear();
                            opcao = menuven.menuVendedor();
                            //----------------------FIM----------------------
                        }if(opcao == "3")
                        {
                            //----------------------CADASTRO ACESSORIOS----------------------
                            Console.WriteLine("     Tela de Cadastro de Acessórios");
                            for (i = 0; i < 4; i++)
                            {
                                acessorio[i] = new Acessorios();
                            }
                            for (i = 0; i < 4; i++)
                            {
                                Console.WriteLine("Digite o nome do Acessório:");
                                acessorio[i].nome = Console.ReadLine();
                                Console.WriteLine("Marca do Acessório:");
                                acessorio[i].marca = Console.ReadLine();
                                Console.WriteLine("Preço");
                                valorstring = Console.ReadLine();
                                acessorio[i].preco = double.Parse(valorstring);
                                Console.WriteLine("O acessório é de algum console: [S/N]");
                                opcao = Console.ReadLine();
                                if (opcao == "S")
                                {
                                    Console.WriteLine("Informe o Console a qual o acessorio pertençe");
                                    acessorio[i].console = Console.ReadLine();
                                }
                                else
                                {
                                    acessorio[i].console = "Acessório não faz parte de nunhum console";
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            opcao = menuven.menuVendedor();
                            //----------------------FIM----------------------
                        }if(opcao == "4")
                        {
                            //----------------------CADASTRO CLIENTES----------------------

                            Console.WriteLine("     Tela de Cadastro de Clientes");
                            for (i = 0; i < 4; i++)
                            {
                                cadastro[i] = new Clientes();
                            }
                            for (i = 0; i < 4; i++)
                            {


                                Console.WriteLine("Digite o nome do Cliente:");
                                cadastro[i].nome = Console.ReadLine();
                                Console.WriteLine("Informe o CPF do Cliente");
                                cadastro[i].cpf = Console.ReadLine();
                                Console.WriteLine("Informe a data de Nascimento do Cliente:");
                                Console.WriteLine("Dia:");
                                valorstring = Console.ReadLine();
                                cadastro[i].dia = int.Parse(valorstring);
                                Console.WriteLine("Mês:");
                                valorstring = Console.ReadLine();
                                cadastro[i].mes = int.Parse(valorstring);
                                Console.WriteLine("Ano:");
                                valorstring = Console.ReadLine();
                                cadastro[i].ano = int.Parse(valorstring);
                                Console.WriteLine("Digite o Endereço do Cliente:");
                                cadastro[i].endereco = Console.ReadLine();
                                Console.WriteLine("Informe o email do cliente:");
                                cadastro[i].email = Console.ReadLine();
                            }
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
                            console[i].AlterarConsoles();

                            Console.ReadKey();
                            Console.Clear();
                            opcao = menu.menu();
                            //----------------------FIM----------------------
                        }if(opcao == "3.1")
                        {
                            //----------------------ALTERAÇÃO DADOS ACESSORIOS---------------------
                            Console.WriteLine("Menu de Alteração de Dados dos Acessorios");
                            Console.WriteLine("Informe o Numero do Acessorio - 0, 1, 2, 3");
                            valorstring = Console.ReadLine();
                            i = int.Parse(valorstring);
                            acessorio[i].AlterarAcessorios();

                            Console.ReadKey();
                            Console.Clear();
                            opcao = menu.menu();
                            //----------------------FIM---------------------- 
                        }if (opcao == "4.1")
                        {
                            //----------------------ALTERAÇÃO DADOS CLIENTES----------------------
                            Console.WriteLine("Menu de Alteração de Dados dos Clienetes");
                            Console.WriteLine("Informe o Numero do Clientes - 0, 1, 2, 3");
                            valorstring = Console.ReadLine();
                            i = int.Parse(valorstring);
                            cadastro[i].AlterarClientes();

                            Console.ReadKey();
                            Console.Clear();
                            opcao = menu.menu();
                            //----------------------FIM---------------------
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
