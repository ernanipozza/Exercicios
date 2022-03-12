using System;

namespace Exercicio10 {
    class Exercicio10 {
        static void Main(string[] args) {
            Console.WriteLine("Informe o salário do servidor Tchurubleigs: ");

            decimal salario;

            while (!decimal.TryParse(Console.ReadLine(), out salario) || salario <= 0) {
                Console.WriteLine("Isso lá é um salário??");
                Console.WriteLine("Vamos tentar mais uma vez: informe a desgraça do salário:");
            }

            decimal aumento = 0;
            
            switch (salario) {
                case decimal n when (n <= 280):
                    aumento = 20;
                    break;
                case decimal n when (n > 280 && n <= 700):
                    aumento = 15;
                    break;
                case decimal n when (n > 700 && n <= 1500):
                    aumento = 10;
                    break;
                case decimal n when (n > 1500):
                    aumento = 5;
                    break;
            }

            decimal salarioReajustado = salario + (salario * (aumento/100));

            Console.WriteLine($"Após um reajuste de {aumento}%, o salário de Tchurubleigs aumentou em R${salarioReajustado - salario}, passando de R${salario} para R${salarioReajustado}");
        }
    }
}
