using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestao {
    class Gerente : Funcionario {
        string Nome { get; set; }
        string CPF { get; set; }
        int Matricula { get; set; }
        DateTime DataInicio { get; set; }
        decimal Salario { get; set; }
        decimal Bonificacao { get; set; }

        public Gerente(string nome, string cPF, int matricula, DateTime dataInicio, decimal salario, decimal bonificacao) : base(nome, cPF, matricula, dataInicio, salario) {
            Nome = nome;
            CPF = cPF;
            Matricula = matricula;
            DataInicio = dataInicio;
            Salario = salario;
            Bonificacao = bonificacao;
        }
    }
}
