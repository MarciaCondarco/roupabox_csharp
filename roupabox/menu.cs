using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ExibirMenu
    {

        public void Menu(Produtos varPro, Clientes varCli)//o (produtos varpro ) são o parametro
        {
            List<ProdutoCad> listaP = new List<ProdutoCad>();
            while (true)
            {
                //produtocad pega o nome da classe do arquivo produtocad 
                //o <produtos> é o mesmo nome que esta no program 

                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("Digite 1 Cadastro de Cliente");
                Console.WriteLine("Digite 2 Listar Cliente");
                Console.WriteLine("Digite 3 Cadastro de Produtos");
                Console.WriteLine("Digite 4 Listar Produto\n");
                Console.WriteLine("Digite a opção escolhida");
                int NumeroEscolhido = int.Parse(Console.ReadLine());

               
              
                if (NumeroEscolhido != 1 && NumeroEscolhido != 2 && NumeroEscolhido != 3 && NumeroEscolhido != 4)
                {
                    Console.WriteLine("\n\nDigite o numero certo ¯\\_(°.°)_/¯ \n\n");
               
                

                    //ExibirMenu variavelmenu = new ExibirMenu();
                    //variavelmenu.Menu(varPro);
                }
                else
                {
                    switch (NumeroEscolhido)
                    {
                        case 0:
                            Console.WriteLine(@"𝚜𝚊𝚒𝚗𝚍𝚘");
                            
                            break;
                        case 1:

                            varCli.cadCliente();
                            break;
                        case 2:
                            varCli.listarCliente();
                            break;
                        case 3:

                            varPro.cadProduto();
                            break;
                        case 4:
                            varPro.listarProduto();
                            break;

                    }
                }

            }

        }
    }
}
