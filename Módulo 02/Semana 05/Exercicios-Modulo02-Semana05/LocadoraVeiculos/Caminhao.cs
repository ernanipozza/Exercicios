using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos {
    public class Caminhao : Veiculos {
        public string Placa { get; set; }
        public string NomeCarro { get; set; }
        public int QuantidadeOcupantes { get; set; }
        public string Combustivel { get; set; }
        public decimal Quilometragem { get; set; }
        public int CargaMaxima { get; set; }

        public Caminhao(string placa, string nomeCarro, int quantidadeOcupantes, string combustivel, decimal quilometragem, int cargaMaxima) : base (placa, nomeCarro, quantidadeOcupantes, combustivel, quilometragem) {
            Placa = placa;
            NomeCarro = nomeCarro;
            QuantidadeOcupantes = quantidadeOcupantes;
            Combustivel = combustivel;
            Quilometragem = quilometragem;
            CargaMaxima = cargaMaxima;
        }
        public override void Andar() {
            Console.WriteLine("Este veículo anda devagar.");
        }
    }
}