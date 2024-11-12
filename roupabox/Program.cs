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
            cabecalho variavelcabecalho = new cabecalho();
            variavelcabecalho.CabecalhoRoupaBox();

            menu variavelmenu = new menu();
            variavelmenu.MenuRoupaBox();
        }
    }
}
