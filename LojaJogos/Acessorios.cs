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
        public string tipo;
        public string marca;
        public string console;
        public double preco;

        public void ListaAcessorios()
        {
            Console.WriteLine("-------x-------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Marca " + marca);
            Console.WriteLine("Console: " + console);
            Console.WriteLine("Preço: R$" + preco);
            Console.ReadKey();
        }
    }
}
