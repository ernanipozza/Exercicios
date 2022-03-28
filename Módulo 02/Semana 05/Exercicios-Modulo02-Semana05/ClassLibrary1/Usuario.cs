using System;

namespace Marketplace {
    public class Usuario {
        string Nome { get; set; }
        string CPF { get; set; }
        string Endereco { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        decimal TotalCompras { get; set; }
        public Usuario(string nome, string cPF, string endereco, string login, string senha, decimal totalCompras) {
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Login = login;
            Senha = senha;
            TotalCompras = totalCompras;
        }
    }
}
