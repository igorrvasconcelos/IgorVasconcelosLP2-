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

            int i, qtd, potencia;
            string nome;
            double km;

            Console.WriteLine("Informe a quantidade de carros");
            qtd = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < qtd; i++)
            {
                Console.WriteLine("Informe o nome do carro");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem do carro");
                km = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potencia do carro");
                potencia = int.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(nome, km, potencia));

            }
        } //static void main

        public static string Classificar(string modelo, double km, int pot)
        {
            string Temp, Pot;

            if (km <= 5000)
                Temp = "novo";

            else if (km <= 30000)
                Temp = "seminovo";

            else
                Temp = "velho";

            if (pot < 120)
                Pot = "popular";

            else if (pot <= 200)
                Pot = "forte";

            else
                Pot = "potente";

            return String.Format("{0} - {1} - {2}", modelo, Temp, Pot);
        }
    }
}
