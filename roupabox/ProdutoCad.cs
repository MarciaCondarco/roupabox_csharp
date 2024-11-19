using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ProdutoCad
    {
        public ProdutoCad (string pro)
        // o pro é o nome para associar o public produtocad (string)
        {
            descPro = pro;
            //aqui mostro que o descpro é o principal
        }
        public string descPro { get; set; }
        //o get;set eles associam e armazenam as informações da variaveis
        public string marcaPro { get; set; }
        public string tamPro { get; set; }
        public string corPro { get; set; }
        public string catPro { get; set; }
        public double valPro { get; set; }
        public double pesoPro { get; set; }
    }
}
