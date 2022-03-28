using System;

namespace LocadoraVeiculos {
    public class Veiculos {

        public string Placa { get; set; }
        public string NomeCarro { get; set; }
        public int QuantidadeOcupantes { get; set; }
        public string Combustivel { get; set; }
        public decimal Quilometragem { get; set; }

        public Veiculos(string placa, string nomeCarro, int quantidadeOcupantes, string combustivel, decimal quilometragem) {
            Placa = placa;
            NomeCarro = nomeCarro;
            QuantidadeOcupantes = quantidadeOcupantes;
            Combustivel = combustivel;
            Quilometragem = quilometragem;
        }

        public virtual void Andar() {
            Console.WriteLine("Este veículo anda.");
        }
    }
}
