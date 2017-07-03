using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N = Int32.Parse(Console.ReadLine());

            Questao[] quest = new Questao[N];
            i = 0;
            while (i < N)
            {
                quest[i] = new Questao();

                quest[i].tA = Int32.Parse(Console.ReadLine());
                quest[i].tB = Int32.Parse(Console.ReadLine());
                quest[i].tC = Int32.Parse(Console.ReadLine());
                quest[i].tD = Int32.Parse(Console.ReadLine());
                quest[i].tE = Int32.Parse(Console.ReadLine());

                i++;
            }

            i = 0;
            while (i < N)
            {
                quest[i].Resposta();
                i++;
            }
        }
    }
}
