using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Menus-----------------
            string opcao;
            Menu menu = new Menu();
            Menu menucli = new Menu();
            Menu menuven = new Menu();
            //---------------FIM---------------

            //----------Metodo Jogos-----------------
            int i;
            string valorstring;
            Jogos[] jogo = new Jogos [2];

            jogo[0] = new Jogos();
            jogo[0].nome = "GTA";
            jogo[0].genero = "Sandbox";
            jogo[0].faixa_etaria = 18;
            jogo[0].estudio = "Rockstar Games";
            jogo[0].preco = 250.00;
            //---------------FIM---------------

            //---------------Metodo Cliente---------------
            Clientes[] cadastro = new Clientes[2];

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
                        opcao = menucli.menuCliente();
                        switch (opcao)
                        {
                            case "1":
                                Console.WriteLine("Lista de Jogos");
                                for (i = 0; i < 2; i++)
                                {
                                    jogo[i].ListaJogos();
                                }
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menu.menu();
                                break;
                        }
                        break;
                    //----------------------FiM CLIENTE----------------------

                    //----------------------MENU VENDEDOR----------------------
                    case "2":
                        opcao = menuven.menuVendedor();
                        switch (opcao)
                        {
                            case "0":
                                Console.WriteLine("Lista de Jogos");
                                for (i = 0; i < 2; i++)
                                {
                                    cadastro[i].ListaDados();
                                }
                                Console.ReadKey();
                                Console.Clear();
                              opcao = menuven.menuVendedor();
                                break;
                            case "1":
                                Console.WriteLine("     Tela de Cadastro de Jogos");
                                for (i = 0; i < 2; i++)
                                {
                                    jogo[i] = new Jogos();
                                }
                                for (i = 0; i < 2; i++)
                                {
                                    Console.WriteLine("Digite o nome do jogo:");
                                    jogo[i].nome = Console.ReadLine();
                                    Console.WriteLine("Informe o genero do jogo::");
                                    jogo[i].genero = Console.ReadLine();
                                    Console.WriteLine("Quanto espaco de memoria o jogo ocupa");
                                    jogo[i].tamanho = Console.ReadLine();
                                    Console.WriteLine("Infome a faixa etaria:");
                                    valorstring = Console.ReadLine();
                                    jogo[i].faixa_etaria = int.Parse(valorstring);
                                    Console.WriteLine("Informe o estudio que desenvolvel o jogo: ");
                                    jogo[i].estudio = Console.ReadLine();
                                    Console.WriteLine("Preço");
                                    valorstring = Console.ReadLine();
                                    jogo[i].preco = double.Parse(valorstring); ;
                                }
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menuven.menuVendedor();
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                Console.WriteLine("     Tela de Cadastro de Clientes");
                                for (i = 0; i < 2; i++)
                                {
                                    cadastro[i] = new Clientes();
                                }
                                for (i = 0; i < 2; i++)
                                {


                                    Console.WriteLine("Digite o nome do paciente:");
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
                                    Console.WriteLine("Digite o Endereço do Clinete:");
                                    cadastro[i].endereco = Console.ReadLine();
                                    Console.WriteLine("Informe o email do clinete:");
                                    cadastro[i].email = Console.ReadLine();
                                }
                                Console.ReadKey();
                                Console.Clear();
                                opcao = menuven.menuVendedor();
                                break;
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
