using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class ContaBancaria {
        
        private int ContaNumero { get; set; }
        private int ContaDigito { get; set; }
        private string NomeTitular { get; set; }
        private string Agencia { get; set; }
        private string Endereco { get; set; }
        private decimal Saldo { get; set; }

        public ContaBancaria( int contaNumero, int contaDigito, string nomeTitular, string agencia, string endereco, decimal saldo) {
            ContaNumero = contaNumero;
            ContaDigito = contaDigito;
            NomeTitular = nomeTitular;
            Agencia = agencia;
            Endereco = endereco;
            Saldo = saldo;
        }

        public int getContaNumero() {
            return ContaNumero;
        }
        public int getContaDigito() {
            return ContaDigito;
        }
        public string getNomeTitular() {
            return NomeTitular;
        }
        public string getAgencia() {
            return Agencia;
        }
        public string getEndereco() {
            return Endereco;
        }
        public decimal getSaldo() {
            return Saldo;
        }
    }
}
