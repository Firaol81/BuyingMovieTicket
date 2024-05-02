namespace MovieTicket.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MovieType { get; set; }
        public DateTime Time { get; set; }
        public string Seat { get; set; }
    }
}