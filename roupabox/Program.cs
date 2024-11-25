using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.CabecalhoRoupaBox();

            Produtos varPro = new Produtos();
            Clientes varCli = new Clientes();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro , varCli);
            //PARA pegar a referencia e criar a variavel do varPro
        }
    }
}
