using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Exercicio03ClasseProtected {

        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected int Passageiros { get; set; }
        protected int Potencia { get; set; }
        protected int Peso { get; set; }
        protected decimal Preco { get; set; }

        public Exercicio03ClasseProtected(string marca, string modelo, int passageiros, int potencia, int peso, decimal preco) {
            Marca = marca;
            Modelo = modelo;
            Passageiros = passageiros;
            Potencia = potencia;
            Peso = peso;
            Preco = preco;
        }

        public Exercicio03ClasseProtected() {

        }

        public static void calculaRelacaoPesoPotencia(Exercicio03ClasseProtected carro) {
            int pesoPotencia = carro.Potencia / carro.Peso;
            Console.WriteLine($"A relação peso-potência do veículo {carro.Modelo} é de {pesoPotencia} cv/kg.");
        }

        public static void calculaCustoPorPassageiro (Exercicio03ClasseProtected carro) {
            decimal custoPorPassageiro = carro.Preco / carro.Passageiros;
            Console.WriteLine($"O custo por passageiro do veículo {carro.Modelo} é de R${custoPorPassageiro}.");
        }
    }
}
