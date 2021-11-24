using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class ConsolesDB
    {
        public string nome;
        public double preço;
        public string marca;

        public void CadastrarConsoles()
        {
            string valorstring;

            Console.WriteLine("Digite o nome do console:");
            nome = Console.ReadLine();
            Console.WriteLine("Preço");
            valorstring = Console.ReadLine();
            preço = double.Parse(valorstring);
            Console.WriteLine("Informe a marca do console:");
            marca = Console.ReadLine();
        }
    }
}
