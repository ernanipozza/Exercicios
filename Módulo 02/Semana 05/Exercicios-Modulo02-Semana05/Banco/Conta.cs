using System;

namespace Banco {
    public class Conta {

        string NomeCliente { get; set; }
        string CPF { get; set; }
        int NumeroConta { get; set; }
        int NumeroAgencia { get; set; }
        decimal Saldo { get; set; }



        public Conta(string nomeCliente, string cPF, int numeroConta, int numeroAgencia, decimal saldo) {
            NomeCliente = nomeCliente;
            CPF = cPF;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Saldo = saldo;
        }

        public Conta() {
        }
    }
}
