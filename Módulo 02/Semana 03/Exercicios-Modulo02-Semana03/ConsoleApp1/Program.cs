using GymAdministration.Core;
using System;
using System.Collections.Generic;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            List<Student> Students = new List<Student> {
                new Student("Januário", "os joelhos estourados", "07/11/1986"),
                new Student("Zuleica", "bico de papagaio", "08/12/1985"),
                new Student("Zózimo", "vontade pra dar e vender", "04/10/1920"),
                new Student("Wilma", "fôlego pra uma maratona", "22/09/1923"),
                new Student("Terêncio", "as costas toda torta", "17/01/1999"),
                new Student("Alzira", "falta de força até pra respirar", "11/11/2001"),
                new Student("Péricles", "o físico de um filé de borboleta", "08/09/1997"),
                new Student("Marilene", "excesso de sono", "01/01/2000"),
                new Student("Merival", "um chassi de grilo", "26/03/1977"),
                new Student("Dioclécia", "um pé na Cova", "28/07/1984")
            };

            List<Equipment> Equipments = new List<Equipment> {
                new Equipment(199458, "Saco de carvão gourmet", "saco de carvão feito com couro retrozigomotizado", "16/09/1974"),
                new Equipment(874090, "Vara de bambu", "bambu grosso, de dar em doido", "05/11/1984"),
                new Equipment(790133, "Milha de tijolos", "uma milha de tijolos feitos na Galera, em Canelinha", "04/03/2022"),
                new Equipment(890940, "Corrente enferrujada", "uma corrente pra prender botijão de gás", "03/01/1963"),
                new Equipment(312987, "Lixa", "uma lixa de massa, pra lixar um muro de 30m x 2,50m", "23/03/2022"),
                new Equipment(234462, "Vassoura", "uma vassoura, pra limpar o forro do salão paroquial", "10/02/1999"),
                new Equipment(544654, "Crachá da Comcap", "um crachá da Comcap, para simular o trabalho pesado desses profissionais exemplares", "06/12/1997"),
                new Equipment(947694, "Bebê recém nascido", "um bebê recém nascido, para simular a privação de sono", "15/02/2022"),
                new Equipment(253442, "Vizinho barulhento", "um vizinho barulhento, para simular o stress", "16/09/1952"),
                new Equipment(191910, "Vazio existencial", "um vazio existencial, para nunca ser preenchido", "16/09/1974")
            };

            List<Employee> Employees = new List<Employee> {
                new Employee ("Jocélions"),
                new Employee ("Ristamartinha"),
                new Employee ("Tobestírcio"),
                new Employee ("Aneria"),
                new Employee ("Mosfabart"),

            };

            Employee employee01 = new Employee("Jocélions");

            Equipment equipment01 = new Equipment(199458, "Saco de carvão gourmet", "saco de carvão feito com couro retrozigomotizado", "16/09/1974");

            ActivityClass activityClass01 = new ActivityClass("Levantamento de saco de carvão", "levar sacos de carvão pra encher o caminhão da loja ", equipment01, "01/01/2022", employee01, Students);



            Console.WriteLine($"A turma de {activityClass01.Name}, que tem como objetivo {activityClass01.Description}, iniciou suas atividades em {activityClass01.StartedActivity}, e conta com o instrutor {activityClass01.Employee.Name} para supervisionar a atividade.");
            Console.WriteLine($"O equipamento usado nessa aula é um {activityClass01.Equipment.Name}, com o id {activityClass01.Equipment.Id}. Ele é um {activityClass01.Equipment.Description} comprado em {activityClass01.Equipment.AcquiredDate}.");
            Console.WriteLine("Os alunos são: ");
            foreach (Student student in Students) {
                Console.WriteLine($" - {student.Name}, que nasceu em {student.BirthdayDate} e tem {student.MedicalObservation}.");
            }
            Console.WriteLine();
            Console.WriteLine("A nossa lista completa de equipamentos: ");
            foreach (Equipment equipment in Equipments) {
                Console.WriteLine($" - {equipment.Name}, de id {equipment.Id}. Ele/a é um/a {equipment.Description}, comprado em {equipment.AcquiredDate}");
            }
            Console.WriteLine();
            Console.WriteLine("A nossa lista completa de instrutores: ");
            foreach (Employee employee in Employees) {
                Console.WriteLine($" - {employee.Name};");
            }
        }
    }
}