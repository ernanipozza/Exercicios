using System;
using System.Collections.Generic;

namespace GymAdministration.Core {
    public class ActivityClass {
        int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string StartedActivity { get; private set; }
        string FinishedActivity { get; set; }
        StatusEnum Status { get; set; }
        public Employee Employee { get; set; }
        public Equipment Equipment { get; set; }
        List<Student> Students { get; set; }

        public ActivityClass(string name, string description, string startedActivity) {
            Name = name;
            Description = description;
            StartedActivity = startedActivity;
            Status = StatusEnum.Active;
        }

        public ActivityClass(string name, string description, Equipment equipment, string startedActivity, Employee employee, List<Student> students) {
            Name = name;
            Description = description;
            Equipment = equipment;
            StartedActivity = startedActivity;
            Status = StatusEnum.Active;
            Employee = employee;
            Students = students;
        }
    }
}
