using System;

namespace SistemaGestao {
    public class Funcionario {
        string Nome { get; set; }
        string CPF { get; set; }
        int Matricula { get; set; }
        DateTime DataInicio { get; set; }
        decimal Salario { get; set; }

        public Funcionario(string nome, string cPF, int matricula, DateTime dataInicio, decimal salario) {
            Nome = nome;
            CPF = cPF;
            Matricula = matricula;
            DataInicio = dataInicio;
            Salario = salario;
        }
    }
}
