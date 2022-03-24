using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Exercicio05 {
       
        public string NomeAnimal { get; set; }
        public int QuantidadePatas { get; set; }
        public string SomEmitido { get; set; }

        public Exercicio05(string nomeAnimal, int quantidadePatas, string somEmitido) {
            NomeAnimal = nomeAnimal;
            QuantidadePatas = quantidadePatas;
            SomEmitido = somEmitido;
        }

        public Exercicio05() {

        }
    }
}
