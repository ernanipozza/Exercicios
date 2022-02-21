using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DihExcerciciosModulo02Semana02
{
    class Exercicio03
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Informe 5 números inteiros.");
            double numeroInformado;
            double[] numerosInformados = new double[5];

            while (!double.TryParse(Console.ReadLine(), out numeroInformado))
            {
                Console.WriteLine("Mas não é possível...");
                Console.WriteLine("Informe o que eu pedi antes");


                for (int i = 0; i < 5; i++)
                {
                    numerosInformados[i] = numeroInformado;
                }
            }


            Console.WriteLine(numerosInformados);


        }
    }
}
