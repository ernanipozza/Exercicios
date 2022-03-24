using System;
using System.ComponentModel.DataAnnotations;

namespace GymAdministration.Core {
    public class Student {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string MedicalObservation { get; private set; }
        public string BirthdayDate { get; private set; }
        public StatusEnum Status { get; private set; }

        public Student(string name, string medicalObservation, string birthdayDate) {
            Name = name;
            MedicalObservation = medicalObservation;
            BirthdayDate = birthdayDate;
            Status = StatusEnum.Active;
        }
    }
}
