using System;

namespace Exercicio07
{
    class Exercicio07
    {
        static void Main(string[] args)
        {
            int numeroInformado;

            Console.WriteLine("Informe um número inteiro com mais de dois dígitos.");

            if (int.TryParse(Console.ReadLine(), out numeroInformado)){
                Console.WriteLine("O número informado foi " + numeroInformado);
            } else
            {
                Console.WriteLine("O valor informado não é um número inteiro");
            }

            int resultado = 0;
            while (numeroInformado > 0)
            {
                int digito = numeroInformado % 10;
                resultado = resultado * 10 + digito;
                numeroInformado /= 10;
            }
            Console.WriteLine("O número revertido é " + resultado);
        }
    }
}