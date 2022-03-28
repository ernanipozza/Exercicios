using System;

namespace Animais {
    public class Mamiferos : Animais {
        string Nome { get; set; }
        int Peso { get; set; }
        string SomEmitido { get; set; }

        public Mamiferos(string nome, int peso, string somEmitido) : base(nome, peso, somEmitido) {
            Nome = nome;
            Peso = peso;
            SomEmitido = somEmitido;
        }
    }
}
