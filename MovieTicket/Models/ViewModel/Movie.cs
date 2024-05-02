// Movie.cs
using System;
using System.Collections.Generic;

namespace MovieTicket.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<DateTime> Showtimes { get; set; }
    }
}