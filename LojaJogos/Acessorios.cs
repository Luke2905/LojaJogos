using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Acessorios
    {
        public string nome;
        public string marca;
        public string console;
        public double preco;

        public void ListaAcessorios()
        {
            Console.WriteLine("-------x-------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Marca " + marca);
            Console.WriteLine("Console: " + console);
            Console.WriteLine("Preço: R$" + preco);
            Console.ReadKey();
        }

        public void AlterarAcessorios()
        {
            string valorstring;
            string opcao;

            Console.WriteLine("Digite o nome do Acessório:");
            nome = Console.ReadLine();
            Console.WriteLine("Marca do Acessório:");
            marca = Console.ReadLine();
            Console.WriteLine("Preço");
            valorstring = Console.ReadLine();
            preco = double.Parse(valorstring);
            Console.WriteLine("O acessório é de algum console: [S/N]");
            opcao = Console.ReadLine();
            if (opcao == "S")
            {
                Console.WriteLine("Informe o Console a qual o acessorio pertençe");
                console = Console.ReadLine();
            }
            else
            {
                console = "Acessório não faz parte de nunhum console";
            }
        }
    }
}
