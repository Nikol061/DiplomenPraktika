namespace VetMedikaDiplomenProekt.Data
{
    public class Hour
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime RegisterOn { get; set; }
        public DateTime DateRegister { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
