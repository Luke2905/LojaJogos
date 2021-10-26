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

        public void AlterarClientes()
        {
            string valorstring;

            Console.WriteLine("Digite o nome do Cliente:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Cliente");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe a data de Nascimento do Cliente:");
            Console.WriteLine("Dia:");
            valorstring = Console.ReadLine();
            dia = int.Parse(valorstring);
            Console.WriteLine("Mês:");
            valorstring = Console.ReadLine();
            mes = int.Parse(valorstring);
            Console.WriteLine("Ano:");
            valorstring = Console.ReadLine();
            ano = int.Parse(valorstring);
            Console.WriteLine("Digite o Endereço do Cliente:");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe o email do cliente:");
            email = Console.ReadLine();
        }
    }
}
