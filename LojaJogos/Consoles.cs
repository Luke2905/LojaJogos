using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Consoles
    {

        public string nome;
        public int tamanho_memoria;
        public double preço;
        public string tipo;
        public string marca;

        public void ListaConsoles()
        {
            Console.WriteLine("-------x-------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Armazeamento Interno: " + tamanho_memoria + " GB");
            Console.WriteLine("Preço: R$" + preço);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Marca " + marca);
            Console.ReadKey();
        }
    }
}
