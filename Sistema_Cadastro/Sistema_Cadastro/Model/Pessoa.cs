using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cadastro
{
    class Pessoa
    {

        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Data { get; set; }
        public float Peso { get; set; }
        public static int Count { get; set; }

    }
}
