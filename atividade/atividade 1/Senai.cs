using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_1
{
    class Senai:Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota do seu aluno de 0 a 100");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do seu aluno de 0 a 100");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a teceira nota do seu aluno de 0 a 100");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota do seu aluno de 0 a 100");
            int nota4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a frequencia do seu aluno de 0 a 100");
            double frequencia = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (frequencia>=90 && media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do Senai");
            }
            else if (frequencia>=70 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (frequencia<90 && media < 7)
            {
                Console.WriteLine("Você foi reprovado por faltas");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
