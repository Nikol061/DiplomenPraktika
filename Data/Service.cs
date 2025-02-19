namespace VetMedikaDiplomenProekt.Data
{
    public class Service
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
