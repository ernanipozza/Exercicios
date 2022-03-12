using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercicio08
{
    class Exercicio08
    {
        static void Main(string[] args)
        {
            string diretorio = @"D:\Programação\DEVinHouse\Exercícios\Módulo 02\Semana 02\Exercicios-Modulo02-Semana02\Exercicio08\notas.json";

            StreamReader notas = new StreamReader(diretorio);
            string jsonString = notas.ReadToEnd();
            List<DataModel> listaAlunos = JsonConvert.DeserializeObject<List<DataModel>>(jsonString);

            foreach (var aluno in listaAlunos) {
                var media = aluno.notas.Sum() / aluno.notas.Count();
                if(media < 5) {
                    Console.WriteLine($"O aluno {aluno.nome} possui média {media}");
                }
            }
        }
    }
}
