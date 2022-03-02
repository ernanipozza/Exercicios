using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            int numeroInformado;
            List<int> numerosInformados = new List<int>();
            int i;

            Console.WriteLine("Informe 10 números inteiros.");

            for (i = 0; i < 10; i++)
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
            
            Console.WriteLine("Os números informados foram: ");
            numerosInformados.ForEach(Console.WriteLine);
            Console.WriteLine("Os números informados, ordenados do maior para o menor são: ");
            numerosInformados.Sort();
            numerosInformados.Reverse();
            Console.WriteLine(string.Join(",", numerosInformados));

        }
    }
}