using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace {
    class VendedorPJ {
        string Nome { get; set; }
        string CNPJ { get; set; }
        int CodigoVendedor { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        public VendedorPJ(string nome, string cNPJ, int codigoVendedor, string login, string senha) {
            Nome = nome;
            CNPJ = cNPJ;
            CodigoVendedor = codigoVendedor;
            Login = login;
            Senha = senha;
        }
    }
}
