// BookingService.cs
using MovieTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket.Services
{
    public class BookingService
    {
        private readonly List<Booking> _bookings; // Assuming you're using a list for simplicity

        public BookingService()
        {
            // Initialize with some sample bookings
            _bookings = new List<Booking>
            {
                new Booking { Id = 1, FirstName = "John", LastName = "Doe", Age = 25, MovieType = "Action", Time = DateTime.Now, Seat = "A1" },
                new Booking { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 30, MovieType = "Comedy", Time = DateTime.Now, Seat = "B2" }
            };
        }

        public List<Booking> GetBookings()
        {
            // Return the list of bookings
            return _bookings.ToList();
        }

        public Booking GetBookingById(int id)
        {
            // Find and return the booking with the specified ID
            return _bookings.FirstOrDefault(b => b.Id == id);
        }

        public void AddBooking(Booking booking)
        {
            // Add the new booking to the list
            _bookings.Add(booking);
        }

        public void UpdateBooking(Booking booking)
        {
            // Find the existing booking by ID and update its properties
            var existingBooking = _bookings.FirstOrDefault(b => b.Id == booking.Id);
            if (existingBooking != null)
            {
                // Update the properties of the existing booking
                existingBooking.FirstName = booking.FirstName;
                existingBooking.LastName = booking.LastName;
                // Update other properties as needed
            }
        }

        public void DeleteBooking(int id)
        {
            // Find and remove the booking with the specified ID
            var bookingToRemove = _bookings.FirstOrDefault(b => b.Id == id);
            if (bookingToRemove != null)
            {
                _bookings.Remove(bookingToRemove);
            }
        }
    }
}