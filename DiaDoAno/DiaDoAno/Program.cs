using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dia;
            string data, m;

            data = Console.ReadLine();

            dia = int.Parse(data.Substring(0, 2));

            if (dia < 10)
                m = data.Substring(5, 4);

            else
                m = data.Substring(6, 4);


            if (m == "feve" || m == "Feve")
                dia = dia + 31;
                
            else if (m == "mar" || m == "Mar")
                dia = dia + 31 + 28;
                
            else if (m == "abri" || m == "Abri")
                dia = dia + (2 * 31) + 28;
                
            else if (m == "maio" || m == "Maio")
                dia = dia + 30 + (2 * 31) + 28;
                
            else if (m == "junh" || m == "Junh")
                dia = dia + 30 + (3 * 31) + 28;
                
            else if (m == "julh" || m == "Julh")
                dia = dia + (2 * 30) + (3 * 31) + 28;
                
            else if (m == "agos" || m == "Agos")
                dia = dia + (2 * 30) + (4 * 31) + 28;
                
            else if (m == "sete" || m == "Sete")
                dia = dia + (2 * 30) + (5 * 31) + 28;
                
            else if (m == "outu" || m == "Outu")
                dia = dia + (3 * 30) + (5 * 31) + 28;
                
            else if (m == "nove" || m == "Nove")
                dia = dia + (3 * 30) + (6 * 31) + 28;
                
            else if (m == "deze" || m == "Deze")
                dia = dia + (4 * 30) + (6 * 31) + 28;

            Console.WriteLine("{0}º", dia);

        }
    }
}
  
