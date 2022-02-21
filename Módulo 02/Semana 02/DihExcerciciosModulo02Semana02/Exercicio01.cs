//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DihExcerciciosModulo02Semana02
//{
//    class Exercicio01
//    {
//        static void Main(string [] args)
//        {
//            Console.WriteLine("Informe um valor que será o raio de um círculo. Vamos calcular a área dele para você! (consideraremos que o valor informado é em centímetros)");
//            double raio;

//            while(!double.TryParse(Console.ReadLine(), out raio))
//            {
//                Console.WriteLine("Eu pedi um raio para calcular a área de um círculo. Você sabe que isso deveria ser um número. Pare de desperdiçar o seu e principalmente o MEU tempo, humano...");
//                Console.WriteLine("Vamos tentar mais uma vez: informe a desgraça do raio:");
//            }

//            var areaCirculo = 3.14159265359 * (raio * raio);
//            Console.WriteLine("A área do círculo é: " + areaCirculo + "cm².");
//        }
//    }
//}
