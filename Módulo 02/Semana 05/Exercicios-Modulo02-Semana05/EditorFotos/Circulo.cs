using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorFotos {
    class Circulo {
        int Raio { get; set; }

        public Circulo(int raio) {
            Raio = raio;
        }

        public void CalculaArea(int raio) {
            Console.WriteLine($"A área do círculo é {3.14159265 * (raio * raio)}");
        }
        public void CalculaPerimetro(int raio) {
            Console.WriteLine($"O perímetro do círculo é {2 * 3.14159265 * raio}");
        }
    }
}
