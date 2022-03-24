using System;

namespace GymAdministration.Core {
    public class Employee {
        int Id { get; set; }
        public string Name { get; private set; }
        string StartedDate { get; set; }
        string? FinishedDate { get; set; }
        StatusEnum Status { get; set; }

        public Employee(string name) {
            Name = name;
            Status = StatusEnum.Active;
        }
    }
}
