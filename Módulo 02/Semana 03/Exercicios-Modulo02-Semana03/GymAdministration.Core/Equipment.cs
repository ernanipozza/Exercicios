using System;

namespace GymAdministration.Core {
    public class Equipment {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string AcquiredDate { get; private set; }

        public Equipment(int id, string name, string description, string acquiredDate) {
            Id = id;
            Name = name;
            Description = description;
            AcquiredDate = acquiredDate;
        }
    }
}
