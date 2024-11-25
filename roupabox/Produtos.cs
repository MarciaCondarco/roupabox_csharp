using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Produtos
    {
        List<ProdutoCad> listaProdutos = new List<ProdutoCad>();
        //listaproduto é variavel
        // list é comando

        public ProdutoCad cadProduto()
        {
            Console.Clear();

            Console.WriteLine(@"Cadastro de Produtos");

            Console.WriteLine("Descreva o produto");
            string descPro = Console.ReadLine();

            var Produto = new ProdutoCad(descPro);
            
            Console.WriteLine("Qual é sua marca?");
            string marcaPro = Console.ReadLine();
            Produto.marcaPro = marcaPro;
            
            Console.WriteLine("Qual o tamanho?");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro;

            Console.WriteLine("Qual a cor do produto?");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro;

            Console.WriteLine("Qual a categoria?");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;

            Console.WriteLine("Escreva o preço da peça?");
            double valPro = double.Parse(Console.ReadLine()); 
            Produto.valPro = valPro;

            Console.WriteLine("Qual é o peso?");
            double pesoPro = double.Parse(Console.ReadLine());
            Produto.pesoPro = pesoPro;

            listaProdutos.Add(Produto);

            Console.WriteLine("produto cadastrdo");
            //faça enquanto - foreach

            Console.WriteLine("digite um coisa");
            Console.ReadKey();
            Console.Clear();

            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.CabecalhoRoupaBox();

            Produtos varPro = new Produtos();
            ExibirMenu variavelMenu = new ExibirMenu();

            return Produto;
        }

        public void listarProduto()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos Cadastrados");

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.descPro}, " + $"Valor: {produto.valPro}" + $"Peso: {produto.pesoPro}");
            }

            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            Cabecalho variavelCabecalho = new Cabecalho();
            variavelCabecalho.CabecalhoRoupaBox();

            Produtos varPro = new Produtos();
            ExibirMenu variavelMenu = new ExibirMenu();

        }

    }
}
