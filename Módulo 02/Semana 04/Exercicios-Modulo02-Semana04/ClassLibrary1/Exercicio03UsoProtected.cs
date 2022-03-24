using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Exercicio03UsoProtected : Exercicio03ClasseProtected {

        static void Main() {

            var fordFocus = new Exercicio03ClasseProtected("Ford", "Focus", 5, 135, 1250, 92000.00M);
            var vwGolf = new Exercicio03ClasseProtected("VW", "Golf", 5, 180, 1290, 145000.00M);
            var gmSpin = new Exercicio03ClasseProtected("GM", "Spin", 7, 120, 1675, 110000.00M);
            var smartFour2 = new Exercicio03ClasseProtected("Smart", "Four2", 2, 80, 764, 90000.00M);

            calculaRelacaoPesoPotencia(fordFocus);
            calculaRelacaoPesoPotencia(vwGolf);
            calculaRelacaoPesoPotencia(gmSpin);
            calculaRelacaoPesoPotencia(smartFour2);

            calculaCustoPorPassageiro(fordFocus);
            calculaCustoPorPassageiro(vwGolf);
            calculaCustoPorPassageiro(gmSpin);
            calculaCustoPorPassageiro(smartFour2);
        }
    }
}
