using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_2
{
    class GerenteTI:Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras feito no mês corrente");
            double QntHorasExtras = Convert.ToDouble(Console.ReadLine());

            if (QntHorasExtras > 100)
            {
                double resul= ((QntHorasExtras/2) * 200 + 500);
                double resultado = (QntHorasExtras / 2) / 8;
            }
            else
            {
                Console.WriteLine("o resultado é igual á " + QntHorasExtras * 400);
            }
        }
    }
}
