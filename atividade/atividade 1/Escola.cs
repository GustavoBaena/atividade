using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_1
{
    abstract class Escola
    {
        
        public abstract void CalcularMedia();
        public static void DescobrirNome()
        {
            Console.WriteLine("Digite o nome de sua escola");
            string escola = Console.ReadLine().ToUpper();
            Console.WriteLine("Agora digite o a sua cidade");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite o estdo em que vc mora");
            string estado = Console.ReadLine();
            Console.WriteLine("E agora digite que serie vc esta na escola");
            string serie = Console.ReadLine();

            if (escola == "SESI/SENAI" && cidade == "Garça")
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine(escola + " " + cidade);
            }


        }
    }
}
