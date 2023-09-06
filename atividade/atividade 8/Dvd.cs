using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.atividade_8
{
    class Dvd
    {
        public int filme;

        public void VerFilmes()
        {
            Console.WriteLine("Digite o nome de dois Filmes que você gosta de assistir");
            string filme = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o Gênero dos filmes e suas Datas de Lançamentos");
            string genero = Convert.ToString(Console.ReadLine());
        }
    }
}
