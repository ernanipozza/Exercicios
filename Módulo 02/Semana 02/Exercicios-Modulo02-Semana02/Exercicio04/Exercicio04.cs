using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            int numeroInformado;
            List<int> numerosInformados = new List<int>();
            int i;

            Console.WriteLine("Informe 7 números inteiros.");

            for (i = 0; i < 7; i++)
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
            int menorNumero = numerosInformados.Min();

            Console.WriteLine("Os números informados foram: ");
            numerosInformados.ForEach(Console.WriteLine);
            Console.WriteLine("O menor dos números informado foi " + menorNumero);
        }
    }
}