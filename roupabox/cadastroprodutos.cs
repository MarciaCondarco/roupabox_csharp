using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace roupabox
{
    internal class cadastroprodutos
    {
        public void CadastroProdutosRoupaBox()
        {
            Console.Clear();

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░");

            Console.WriteLine("Qual é sua marca?");
            string marcaPro = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(marcaPro))
            {
                Console.WriteLine("errou");

            }
            else
            {

            }
            
            Console.WriteLine("Qual o tamanho?");
            string tamPro = Console.ReadLine();
            Console.WriteLine("Qual a cor do produto?");
            string corPro = Console.ReadLine();
            Console.WriteLine("Qual a categoria?");
            string catPro = Console.ReadLine();
            Console.WriteLine("Descreva o produto");
            string descPro = Console.ReadLine();
            Console.WriteLine("Escreva o preço da peça?");
            double valPro = double.Parse(Console.ReadLine()); 
            while (!double.TryParse(Console.ReadLine(), out valPro))
            {

            }
            Console.WriteLine("Qual é o peso?");
            double pesoPro = double.Parse(Console.ReadLine());
        }
    }
}
