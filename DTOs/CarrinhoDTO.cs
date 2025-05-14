using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    internal class CarrinhoDTO 
    {
        public int id_produtos { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set; }
        public string imagem { get; set; }
        public int quantidade { get; set; }


    }
}
