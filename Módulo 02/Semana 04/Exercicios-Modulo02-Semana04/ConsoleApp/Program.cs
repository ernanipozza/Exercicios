using ClassLibrary1;
using System;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {

            //Exercicio 04 e Exercicio 06
            
            int valorA = 9;
            int valorB = 3;
            int valorC = 1;
            Console.WriteLine($"A soma de {valorA} e {valorB} é {Calculadora.somar(valorA, valorB)}.");
            Console.WriteLine($"A soma de {valorA}, {valorB} e {valorC} é {Calculadora.somar(valorA, valorB, valorC)}.");
            Console.WriteLine($"A subtração de {valorA} e {valorB} é {Calculadora.subtrair(valorA, valorB)}.");
            Console.WriteLine($"A subtração de {valorA}, {valorB} e {valorC} é {Calculadora.subtrair(valorA, valorB, valorC)}.");
            Console.WriteLine($"A multiplicação de {valorA} e {valorB} é {Calculadora.multiplicar(valorA, valorB)}.");
            Console.WriteLine($"A multiplicação de {valorA}, {valorB} e {valorC} é {Calculadora.multiplicar(valorA, valorB, valorC)}.");
            Console.WriteLine($"A divisão de {valorA} e {valorB} é {Calculadora.dividir(valorA, valorB)}.");
            Console.WriteLine($"A divisão de {valorA}, {valorB} e {valorC} é {Calculadora.dividir(valorA, valorB, valorC)}.");


            //Exercício 05
            /*var pato = new Exercicio05("pato", 2, "grasnado");
            var cachorro = new Exercicio05("cachorro", 4, "latido");
            var gato = new Exercicio05();
            var sapo = new Exercicio05();
            Console.WriteLine($"O {pato.NomeAnimal} tem {pato.QuantidadePatas} patas e emite um {pato.SomEmitido}.");
            Console.WriteLine($"O {cachorro.NomeAnimal} tem {cachorro.QuantidadePatas} patas e emite um {cachorro.SomEmitido}.");
            Console.WriteLine($"O {gato.NomeAnimal} tem {gato.QuantidadePatas} patas e emite um {gato.SomEmitido}.");
            Console.WriteLine($"O {sapo.NomeAnimal} tem {sapo.QuantidadePatas} patas e emite um {sapo.SomEmitido}.");
            */
        }
    }
}
