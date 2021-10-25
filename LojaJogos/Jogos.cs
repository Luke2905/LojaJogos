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
            Console.ReadKey();
        }

    }
}
