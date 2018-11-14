using System;
using Web.Api.Core.Shared;

namespace Web.Api.Core.Domain.Entities
{
    public class Player : BaseEntity
    {
        public string FirstName { get; private set; } // EF migrations require at least private setter - won't work on auto-property
        public string LastName { get; private set; }
        public int HeightCm { get; private set; }
        public decimal WeightKg { get; private set; }
        public DateTime BirthDate { get; private set; }

        internal Player() { /* Required by EF */ }

        internal Player(string firstName, string lastName, int heightCm, decimal weightKg,DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            HeightCm = heightCm;
            WeightKg = weightKg;
            BirthDate = birthDate;
        }
    }
}
