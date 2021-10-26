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

        public void AlterarConsoles()
        {
            string valorstring;

            Console.WriteLine("Digite o nome do console:");
            nome = Console.ReadLine();
            Console.WriteLine("Memoria Interna do Console:");
            valorstring = Console.ReadLine();
            tamanho_memoria = int.Parse(valorstring);
            Console.WriteLine("Preço");
            valorstring = Console.ReadLine();
            preço = double.Parse(valorstring);
            Console.WriteLine("Informe o tipo do console (de mesa ou portatil): ");
            tipo = Console.ReadLine();
            Console.WriteLine("Informe a marca do console:");
            marca = Console.ReadLine();
        }
    }
}
