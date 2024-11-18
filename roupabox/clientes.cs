using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class clientes
    {
        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\n Digite o Nome Completo do Cliente:  ");
            string nomeCli = Console.ReadLine();
            // nome da variavel para armazenar o nome 
            Console.Clear();
            Console.WriteLine("\n Digite o CPF do cliente:  (com apenas 11 caracteres)");
            string cpfCli = Console.ReadLine();
            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))//todos os caracteres tem que ser numeros - all(char.isdigit)
            {
                Console.WriteLine("cpf invalido, faz de novo");
                cpfCli = Console.ReadLine();
            }

            Console.WriteLine("\nDigite o telefone do Cliente:  ");
            long telCli = long.Parse(Console.ReadLine());
            while (telCli.lenght != 11 || !telCli.All(char.IsDigit))
            {
                Console.WriteLine("");
            }

            Console.WriteLine("\n Digite a sua idade:  ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite seu email ");
            string emailCli = Console.ReadLine();
            while (!emailCli.Contains('@'))//o contains é de conter algo dentro do parenteste e aspas
            {
                Console.WriteLine("erro, digite novamente o email");
                emailCli = Console.ReadLine();
            }


            Console.WriteLine("\ndigite seu sexo");
            string sexoCli = Console.ReadLine();

            Console.WriteLine("\n Digite a rua");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\n Digite um complemento");
            string compCli = Console.ReadLine();

            Console.WriteLine("\n Digite o numero da casa");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu bairro");
            string bairroCli = Console.ReadLine();

            Console.WriteLine("\n Digite a sua cidade");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\n digite o seu estado");
            string estCli = Console.ReadLine();

            Console.WriteLine("\n Digite o seu cep");
            long cepCli = long.Parse(Console.ReadLine());


            Console.WriteLine("\n Cliente cadastrado com sucesso");
            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal ");
            Console.ReadKey();
            ///o readkey quando não clicar nada vai ficar naquela tecla 
            Console.Clear();
            cabecalho variavelcabecalho = new cabecalho();
            variavelcabecalho.CabecalhoRoupaBox();

            menu variavelmenu = new menu();
            variavelmenu.MenuRoupaBox();

        }
    }
}
