using atividade.atividade_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_2
{
    class Desenvolvedor:Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a modalidade de trabalho A-Prsencial B-Hibrido C-Remoto");
            string modalidade = Console.ReadLine().ToUpper();

            if (modalidade == "A")
            {
                Console.WriteLine("Digite a quantidade de horas extras que o seu colaborador possui");
                double QntHorasExtras = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Você tem mais " + (QntHorasExtras * 100));
            }
            else if (modalidade == "B")
            {
                Console.WriteLine("Digite a quantidade de horas extras que o seu colaborador possui");
                double QntHorasExtras = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Você tem mais " + (QntHorasExtras * 50));
            }
            else if (modalidade == "c")
            {
                Console.WriteLine("O seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então não contempla horas extras");

            }
            else
            {
                Console.WriteLine("Você digitou uma opção inválida");
            }

        }
    }
}
