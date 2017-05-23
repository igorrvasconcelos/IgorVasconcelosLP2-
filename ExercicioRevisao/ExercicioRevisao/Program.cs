using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, Temp, Pot;
            double km, potencia;
            int i, qtd;

            Console.WriteLine("Informe a quantidade de carros");
            qtd = int.Parse(Console.ReadLine());

            for (i = 0; i < qtd; i++)
            {
                Console.WriteLine("Informe o modelo do carro");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem do carro");
                km = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a potencia do carro");
                potencia = Convert.ToDouble(Console.ReadLine());

                if (km < 5000)
                    Temp = "novo";

                else if (km >= 5000 && km <= 30000)
                    Temp = "seminovo";

                else
                    Temp = "velho";

                if (potencia > 200)
                    Pot = "potente";

                else if (potencia > 120 && potencia <= 200)
                    Pot = "forte";

                else
                    Pot = "popular";
                Console.WriteLine("O {0} - {1} - {2}", modelo, Temp, Pot);
            }
        }
    }
}
