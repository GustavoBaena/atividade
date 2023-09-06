using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_1
{
    class Sesi:Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota do seu aluno");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do seu aluno");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a teiceira nota do seu aluno");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            int media = (nota1 + nota2 + nota3)/3;

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media <= 8)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
