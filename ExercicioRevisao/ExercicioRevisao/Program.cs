﻿using System;
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
            string modelo;
            double km, pot;

            Console.WriteLine("Informe o modelo");
            modelo = Console.ReadLine();
            Console.WriteLine("Informe a quilometragem");
            km = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a potencia");
            pot = double.Parse(Console.ReadLine());

            string classifRodagem, classifPot;

            if (km <= 5000)
                classifRodagem = "novo";
            else if (km <= 30000)
                classifRodagem = "semi novo";
            else
                classifRodagem = "velho";

            if (pot > 200)
                classifPot = "potente";
            else if (pot < 200 && pot > 120)
                classifPot = "forte";
            else
                classifPot = "popular";
            Console.WriteLine("{0} - {1} - {2}", modelo, classifRodagem, classifPot);
            Console.ReadKey();
        }
    }
}
