using Web.Api.Core.Shared;

namespace Web.Api.Core.Domain.Entities
{
    public class Player : BaseEntity
    {
        public string FirstName { get; private set; } // EF migrations require at least private setter - won't work on auto-property
        public string LastName { get; private set; }
        public int HeightCm { get; private set; }
        public decimal WeightLbs { get; private set; }

        internal Player() { /* Required by EF */ }

        internal Player(string firstName, string lastName, int heightCm, decimal weightLbs)
        {
            FirstName = firstName;
            LastName = lastName;
            HeightCm = heightCm;
            WeightLbs = weightLbs;
        }
    }
}
