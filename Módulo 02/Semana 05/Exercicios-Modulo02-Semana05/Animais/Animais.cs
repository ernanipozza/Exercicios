using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais {
    public class Animais {
        string Nome { get; set; }
        int Peso { get; set; }
        string SomEmitido { get; set; }

        public Animais(string nome, int peso, string somEmitido) {
            Nome = nome;
            Peso = peso;
            SomEmitido = somEmitido;
        }
    }
}
