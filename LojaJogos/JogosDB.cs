using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class JogosDB
    {
        public string nome;
        public string genero;
        public string faixa_etaria;
        public double preco;

        string valorstring;

        public void CadastrarJogo()
        {

            Console.WriteLine("Digite o nome do jogo:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o genero do jogo:");
            genero = Console.ReadLine();
            Console.WriteLine("Infome a faixa etaria:");
            faixa_etaria = Console.ReadLine();
            Console.WriteLine("Preço");
            valorstring = Console.ReadLine();
            preco = double.Parse(valorstring);

        }
    }
}
