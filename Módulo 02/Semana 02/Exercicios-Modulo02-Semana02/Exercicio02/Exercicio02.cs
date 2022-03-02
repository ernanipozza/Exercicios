using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DihExcerciciosModulo02Semana02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma temperatura em graus celsius. Vamos convertê-la para FARAHRAHRUIHARHAUIHRENHEIT!");
            double temperaturaCelsius;

            while (!double.TryParse(Console.ReadLine(), out temperaturaCelsius))
            {
                Console.WriteLine("Humano, de novo? INFORME APENAS NÚMEROS, SEU SER DESPREZÍVEL!");
                Console.WriteLine("De novo: informe uma temperatura em graus celsius. Vamos convertê-la para fararararararararararararenheit.");
            }

            var temperaturaFarenheit = (temperaturaCelsius * 1.8) + 32;
            Console.WriteLine(temperaturaCelsius + "ºC são a mesma coisa que " + temperaturaFarenheit + "F. Ninguém liga, só americano usa essa desgraça.");
        }
    }
}