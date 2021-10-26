using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Jogos
    {
        public string nome;
        public string genero;
        public int faixa_etaria;
        public double preco;
        public string tamanho;
        public string estudio;


        public void ListaJogos()
        {
            Console.WriteLine("-------x-------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Classificação Etária: " + faixa_etaria);
            Console.WriteLine("Tamanho do Jogo: " + tamanho);
            Console.WriteLine("Preço: R$ " + preco);
            Console.WriteLine("Estudio: " + estudio);
        }

        public void AlterarJogos()
        {
            string valorstring;

            Console.WriteLine("Digite o nome do jogo:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o genero do jogo::");
            genero = Console.ReadLine();
            Console.WriteLine("Quanto espaco de memoria o jogo ocupa");
            tamanho = Console.ReadLine();
            Console.WriteLine("Infome a faixa etaria:");
            valorstring = Console.ReadLine();
            faixa_etaria = int.Parse(valorstring);
            Console.WriteLine("Informe o estudio que desenvolvel o jogo: ");
            estudio = Console.ReadLine();
            Console.WriteLine("Preço");
            valorstring = Console.ReadLine();
            preco = double.Parse(valorstring);

            }
    }
}
