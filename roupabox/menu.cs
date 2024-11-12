using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    internal class menu
    {
        public void MenuRoupaBox()
        {
            Console.WriteLine("Digite 0 para sair");
            Console.WriteLine("Digite 1 Cadastro de Cliente");
            Console.WriteLine("Digite 2 Listar Cliente");
            Console.WriteLine("Digite 3 Cadastro de Produtos");
            Console.WriteLine("Digite 4 Listar Produto\n");
            Console.WriteLine("Digite a opção escolhida");
            int NumeroEscolhido = int.Parse (Console.ReadLine());

            Thread.Sleep(2000);
            Console.Clear();

            switch(NumeroEscolhido)
            {
                case 0:
                    Thread.Sleep(3000);
                    break;
                case 1:
                    cadastrocliente variavelcadastrocliente = new cadastrocliente();
                    variavelcadastrocliente.CadastroClienteRoupaBox();
                    break;
                case 2:
                    listarclientes variavellistarclientes = new listarclientes();
                    variavellistarclientes.ListarClientesRoupaBox();
                    break;
                case 3:
                    cadastroprodutos variavelcadastroproduto = new cadastroprodutos();
                    variavelcadastroproduto.CadastroProdutosRoupaBox();
                    break;
                case 4:
                    listarprodutos variavellistarprodutos = new listarprodutos();
                    variavellistarprodutos.ListarProdutosRoupaBox();
                    break;

            }

        }
    }
}
