using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Clientes
    {
        public string nome;
        public int dia;
        public int mes;
        public int ano;
        public string endereco;
        public string cpf;
        public string email;

        public void ListaDados()
        {
            Console.WriteLine("-----------X----------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Data de Nascimento: " + dia + "/" + mes + "/" + ano);
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("email: " + email);
        }
    }
}
