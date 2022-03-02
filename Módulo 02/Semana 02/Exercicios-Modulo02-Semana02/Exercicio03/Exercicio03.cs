using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DihExcerciciosModulo02Semana02
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            int numeroInformado;
            List<int> numerosInformados = new List<int>();
            int i;

            Console.WriteLine("Informe 5 números inteiros.");

            for (i = 0; i < 5; i++)
            {
                if (int.TryParse(Console.ReadLine(), out numeroInformado))
                {
                    numerosInformados.Add(numeroInformado);
                }
                else
                {
                    Console.WriteLine("Você não informou um número inteiro");
                    i--;
                }
            }
            int maiorNumero = numerosInformados.Max();

            Console.WriteLine("Os números informados foram: ");
            numerosInformados.ForEach(Console.WriteLine);
            Console.WriteLine("O maior dos números informado foi " + maiorNumero);
        }
    }
}