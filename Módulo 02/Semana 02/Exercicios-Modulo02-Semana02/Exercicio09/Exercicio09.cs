using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercicio09 {
    class Exercicio09 {
        static void Main(string[] args) {
            string diretorioLer = @"D:\Programação\DEVinHouse\Exercícios\Módulo 02\Semana 02\Exercicios-Modulo02-Semana02\Exercicio09\notas.json";
            string diretorioSalvar = @"D:\Programação\DEVinHouse\Exercícios\Módulo 02\Semana 02\Exercicios-Modulo02-Semana02\Exercicio09\Reprovados.txt";

            StreamReader notas = new StreamReader(diretorioLer);
            string jsonString = notas.ReadToEnd();
            List<DataModel> listaAlunos = JsonConvert.DeserializeObject<List<DataModel>>(jsonString);
            List<DataModel> listaReprovados = new List<DataModel>();

            foreach (var aluno in listaAlunos) {
                var media = aluno.notas.Sum() / aluno.notas.Count();
                if (media < 5) {
                    listaReprovados.Add(aluno);
                }
            }

            if (!File.Exists(diretorioSalvar)) {
                using (StreamWriter sw = File.CreateText(diretorioSalvar)) {
                    var jsonReprovados = JsonConvert.SerializeObject(listaReprovados);
                    List<DataModel> listaAlunosReprovados = JsonConvert.DeserializeObject<List<DataModel>>(jsonReprovados);
                    foreach (var alunoReprovado in listaAlunosReprovados) {
                        sw.WriteLine($"O aluno {alunoReprovado.nome} foi reprovado com a média {alunoReprovado.notas.Sum() / alunoReprovado.notas.Count()}");
                    }
                }
            }
        }
    }
}
