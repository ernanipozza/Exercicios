using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorFotos {
    class Triangulo {
        int Base { get; set; }
        int Altura { get; set; }
        int LadoA { get; set; }
        int LadoB { get; set; }
        int LadoC { get; set; }

        public Triangulo(int baseTriangulo, int altura, int ladoA, int ladoB, int ladoC) {
            Base = baseTriangulo;
            Altura = altura;
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public void CalculaArea(int baseTriangulo, int alturaTriangulo) {
            Console.WriteLine($"A área do triângulo é {(baseTriangulo * alturaTriangulo) / 2}");
        }

        public void CalculaPerimetro(int ladoA, int ladoB, int ladoC) {
            Console.WriteLine($"O perímetro do triângulo é {ladoA + ladoB + ladoC}");
        }
    }
}
