using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Clientes
    {
        List <ClienteCad> listaClientes = new List<ClienteCad> ();
        public ClienteCad cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\n Digite o Nome Completo do Cliente:  ");
            string nomeCli = Console.ReadLine();
            var Cliente = new ClienteCad(nomeCli);
            while (string.IsNullOrEmpty(nomeCli))
            {
                Console.WriteLine("você não escreveu nada!!!!!!! escreva seu nome ಠ_ಠ");
            }
            // nome da variavel para armazenar o nome 
            Console.Clear();
            Console.WriteLine("\n Digite o CPF do cliente:  (com apenas 11 caracteres)");
            string cpfCli = Console.ReadLine();

            //while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))//todos os caracteres tem que ser numeros - all(char.isdigit)
            //{
            //    Console.WriteLine("cpf invalido, faz de novo");
            //    cpfCli = Console.ReadLine();
            //}
            while (string.IsNullOrEmpty(cpfCli) || cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("Escreva o seu cpf    ಥ_ಥ");
                cpfCli = Console.ReadLine();
             
            }
            Cliente.cpfCli = cpfCli;

            Console.WriteLine("\nDigite o telefone do Cliente:  ");
            string telCli = Console.ReadLine();
            Cliente.telCli = telCli;
            //while (telCli.lenght != 11 || !telCli.All(char.IsDigit))
            //{
            //    Console.WriteLine("deu certo");
            //}

            Console.WriteLine("\n Digite a sua idade:  ");
            int idadeCli = int.Parse(Console.ReadLine());
            Cliente.idadeCli = idadeCli;

            Console.WriteLine("\n Digite seu email ");
            string emailCli = Console.ReadLine();
            Cliente.emailCli = emailCli;
            while (!emailCli.Contains('@'))//o contains é de conter algo dentro do parenteste e aspas
            {
                Console.WriteLine("erro, digite novamente o email");
                emailCli = Console.ReadLine();
            }


            Console.WriteLine("\ndigite seu sexo");
            string sexoCli = Console.ReadLine();
            Cliente.sexoCli = sexoCli;



            Console.WriteLine("\n Digite a rua");
            string ruaCli = Console.ReadLine();
            Cliente.ruaCli = ruaCli;

            Console.WriteLine("\n Digite um complemento");
            string compCli = Console.ReadLine();
            Cliente.compCli = compCli;

            Console.WriteLine("\n Digite o numero da casa");
            int numCli = int.Parse(Console.ReadLine());
            Cliente.numCli = numCli;

            Console.WriteLine("Digite o seu bairro");
            string bairroCli = Console.ReadLine();
            Cliente.bairroCli = bairroCli;

            Console.WriteLine("\n Digite a sua cidade");
            string cidCli = Console.ReadLine();
            Cliente.cidCli = cidCli;

            Console.WriteLine("\n digite o seu estado");
            string estCli = Console.ReadLine();
            Cliente.estCli = estCli;

            Console.WriteLine("\n Digite o seu cep");
            string cepCli = Console.ReadLine();
            Cliente.cepCli = cepCli;

            listaClientes.Add(Cliente);

            Console.WriteLine("\n Cliente cadastrado com sucesso");
            foreach (var Clientes in listaClientes)
            {
                Console.WriteLine($"Nome: {Cliente.nomeCli}, " + $"cpf: {Cliente.cpfCli}");
            }
            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal ");
            Console.ReadKey();
            ///o readkey quando não clicar nada vai ficar naquela tecla 
            Console.Clear();


            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.CabecalhoRoupaBox();

            ExibirMenu variavelmenu = new ExibirMenu();
            //variavelmenu.Menu();

            return Cliente;


        }
    }
}
