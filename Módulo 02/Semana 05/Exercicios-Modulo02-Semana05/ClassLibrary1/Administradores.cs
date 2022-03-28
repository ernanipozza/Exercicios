using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace {
    class Administradores {
        string Nome { get; set; }
        string CPF { get; set; }
        int CódigoAdmin { get; set; }
        string Login { get; set; }
        string Senha { get; set; }

        public Administradores(string nome, string cPF, int códigoAdmin, string login, string senha) {
            Nome = nome;
            CPF = cPF;
            CódigoAdmin = códigoAdmin;
            Login = login;
            Senha = senha;
        }
    }
}
