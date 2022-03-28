using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestao {
    class Comprador : Funcionario {
        string Nome { get; set; }
        string CPF { get; set; }
        int Matricula { get; set; }
        DateTime DataInicio { get; set; }
        decimal Salario { get; set; }

        public Comprador(string nome, string cPF, int matricula, DateTime dataInicio, decimal salario) : base(nome, cPF, matricula, dataInicio, salario) {
            Nome = nome;
            CPF = cPF;
            Matricula = matricula;
            DataInicio = dataInicio;
            Salario = salario;
        }
    }
}
