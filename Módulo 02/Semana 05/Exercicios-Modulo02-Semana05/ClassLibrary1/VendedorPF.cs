using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace {
    class VendedorPF {
        string Nome { get; set; }
        string CPF { get; set; }
        int CodigoVendedor { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        public VendedorPF(string nome, string cPF, int codigoVendedor, string login, string senha) {
            Nome = nome;
            CPF = cPF;
            CodigoVendedor = codigoVendedor;
            Login = login;
            Senha = senha;
        }
    }
}
