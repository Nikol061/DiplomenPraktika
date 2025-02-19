namespace VetMedikaDiplomenProekt.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Services { get; set; }
        public string UserId { get; set; }//fk
        public User Users { get; set; } //m:1 tablica

        public DateTime TimeReservation { get; set; }
        public DateTime DateReservation { get; set; }
        public string Description { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
