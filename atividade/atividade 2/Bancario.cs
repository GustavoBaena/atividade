using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_2
{
    class Bancario: Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras feito no mês corrente");
            double QntHorasExtras = Convert.ToDouble(Console.ReadLine());

            double Calculo = (QntHorasExtras * 250);

            if (Calculo > 500)
            {
                Console.WriteLine("O novo valor é igual á " + (Calculo * 1.10));
            }
            else if (Calculo > 1000)
            {
                Console.WriteLine("O novo valor é igual á "+(Calculo*1.15));
            }
            else
            {
                Console.WriteLine(Calculo);
            }
        }
    }
}
