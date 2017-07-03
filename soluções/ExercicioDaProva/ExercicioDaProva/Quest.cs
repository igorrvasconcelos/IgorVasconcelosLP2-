using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDaProva
{
    class Quest
    {
        public int tA, tB, tC, tD, tE, nresposta, ninv;
        public string resposta;

        public void Resposta()
        {

            nresposta = 0;
            ninv = 0;
            if (tA <= 100)
            {
                resposta = "A";
                nresposta++;
            }
            else if (tA <= 155)
                ninv++;

            if (tB <= 100)
            {
                resposta = "B";
                nresposta++;
            }
            else if (tB <= 155)
                ninv++;

            if (tC <= 100)
            {
                resposta = "C";
                nresposta++;
            }
            else if (tC <= 155)
                ninv++;

            if (tD <= 100)
            {
                resposta = "D";
                nresposta++;
            }
            else if (tD <= 155)
                ninv++;

            if (tE <= 100)
            {
                resposta = "E";
                nresposta++;
            }
            else if (tE <= 155)
                ninv++;

            if (nresposta != 1 || ninv != 0)
                Console.WriteLine("*");

            else
                Console.WriteLine(resposta);
        }
    }
}
    

