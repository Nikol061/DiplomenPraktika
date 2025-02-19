using Microsoft.AspNetCore.Identity;

namespace VetMedikaDiplomenProekt.Data
{
    public class User:IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateRegister { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
