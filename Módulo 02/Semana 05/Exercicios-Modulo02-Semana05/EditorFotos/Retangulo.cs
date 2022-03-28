using System;

namespace EditorFotos {
    public class Retangulo {
        int LadoA { get; set; }
        int LadoB { get; set; }

        public Retangulo(int ladoA, int ladoB) {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public void calculaArea(int ladoA, int ladoB) {
            Console.WriteLine($"A área do retângulo é {ladoA * ladoB}");
        }

        public void calculaPerimetro (int ladoA, int ladoB) {
            Console.WriteLine($"O perímetro do retângulo é {(ladoA * 2) + (ladoB * 2)}");
        }
    }
}
