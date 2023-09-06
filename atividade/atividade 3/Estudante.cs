using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.ativiade_3
{
    class Estudante
    {
        public string  Nome { get; set; }
        public int  Idade{ get; set; }

        public string  Cidade { get; set; }

        public string  Estado { get; set; }

        public Projeto Projeto { get; set; }
    }
}
