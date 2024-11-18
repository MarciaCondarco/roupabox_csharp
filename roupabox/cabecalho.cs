using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    internal class cabecalho
    {
        public void CabecalhoRoupaBox ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"═════════════════════════════════════");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Autor: Marcia Condarco");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"═════════════════════════════════════");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"═════════════════════════════════════");
            Console.ForegroundColor= ConsoleColor.White;

            Thread.Sleep(3000);
            Console.Clear();

        }
    }
}
