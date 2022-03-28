using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorFotos {
    public class Quadrado {
        int Lado { get; set; }
        public Quadrado(int lado) {
            Lado = lado;
        }

        public void calculaArea(int lado) {
            Console.WriteLine($"A área do retângulo é {lado * lado}");
        }

        public void calculaPerimetro(int lado) {
            Console.WriteLine($"O perímetro do retângulo é {lado * 4}");
        }
    }
}
