using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.ativiade_3
{
    class Projeto
    {
        public string DataDoProjeto { get; set; }

        public void EscolherProfissão()
        {
            Console.WriteLine("Qual profissão gostaria de escolher?");
            string Profissao = Console.ReadLine();
            Console.Write("Qual faculdade gostaria de cusar?");
            string Faculdade = Console.ReadLine();
            Console.WriteLine("Citar 3 coisas que gostaria de estar fazendo daqui a 5 anos?");
            string Citar = Console.ReadLine();
            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string Expectativa = Console.ReadLine();
            Console.WriteLine("Citar 3 características de quais são os seus projetos para o futuro?");
            string Citar2= Console.ReadLine();

            Console.WriteLine(Profissao);
            Console.WriteLine(Faculdade);
            Console.WriteLine(Citar);
            Console.WriteLine(Expectativa);
            Console.WriteLine(Citar2);

        }
    }
}
