using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LivrosDeHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            double tl, hd, pagh ,dataentrega, tt;
            int npag, qtdl, i=0;
            string titulo;

            Console.WriteLine("informe o tempo de leitura");
            tl = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quantidade de livros");
            qtdl=int.Parse(Console.ReadLine());

            Livro[]livros = new Livro[qtdl];

            for (i = 0; i <= qtdl; i++)
            {
                Livro hermione = new Livro();

                Console.WriteLine("informe a data de entrega");
                dataentrega = Convert.ToDouble(Console.ReadLine());
                Livro.dataentrega = dataentrega;

                Console.WriteLine("informe o numero de paginas do livro");
                npag = int.Parse(Console.ReadLine());
                Livro.npag = npag;

                

            }
            

        }
    }
}
