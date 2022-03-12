using System;

namespace Exercicio06
{
    class Exercicio06
    {
        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            Console.WriteLine("Informe 3 números inteiros, que serão os lados de um triângulo");
            if (!(int.TryParse(Console.ReadLine(), out ladoA) && int.TryParse(Console.ReadLine(), out ladoB) && int.TryParse(Console.ReadLine(), out ladoC) && (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA)))
            {
                Console.WriteLine("Com os dados informados não é possível formar um triângulo.");
            } else
            {
                if (ladoA == ladoB && ladoA == ladoC)
                {
                    Console.WriteLine("Com os dados informados, você formou um triângulo equilátero.");
                } else if ((ladoA == ladoB && ladoA != ladoC) || (ladoA != ladoB && ladoA == ladoC) || (ladoB == ladoC && ladoB != ladoA))
                {
                    Console.WriteLine("Com os dados informados, você formou um triângulo isósceles.");
                } else
                {
                    Console.WriteLine("Com os dados informados, você formou um triângulo escaleno.");
                }
            }


        }
    }
}
