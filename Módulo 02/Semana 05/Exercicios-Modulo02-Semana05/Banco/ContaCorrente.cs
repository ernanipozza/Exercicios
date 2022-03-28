using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    class ContaCorrente : Conta {
        string NomeCliente { get; set; }
        string CPF { get; set; }
        int NumeroConta { get; set; }
        int NumeroAgencia { get; set; }
        decimal Saldo { get; set; }

        public ContaCorrente(string nomeCliente, string cPF, int numeroConta, int numeroAgencia, decimal saldo) : base(nomeCliente, cPF, numeroConta, numeroAgencia, saldo) {
            NomeCliente = nomeCliente;
            CPF = cPF;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Saldo = saldo;
        }

        public ContaCorrente() {
        }
    }
}
