using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Models
{
    public class BookingViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "Movie type is required")]
        public string MovieType { get; set; }

        [Required(ErrorMessage = "Time is required")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Seat is required")]
        public string Seat { get; set; }

        // Add other properties as needed
    }
}