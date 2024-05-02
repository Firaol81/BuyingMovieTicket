using Microsoft.AspNetCore.Mvc;
using MovieTicket.Models;
using MovieTicket.Services;

namespace MovieTicket.Controllers
{
    public class BookingController : Controller
    {
        private readonly BookingService _bookingService;

        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBooking(BookingViewModel bookingViewModel)
        {
            if (ModelState.IsValid)
            {
                var booking = MapBookingViewModelToBooking(bookingViewModel);
                _bookingService.AddBooking(booking);
                return RedirectToAction("BookingConfirmation");
            }
            return View(bookingViewModel);
        }

        [HttpGet]
        public IActionResult EditBooking(int id)
        {
            var booking = _bookingService.GetBookingById(id);
            if (booking == null)
            {
                return NotFound();
            }

            var bookingViewModel = MapBookingToBookingViewModel(booking);
            return View(bookingViewModel);
        }

        [HttpPost]
        public IActionResult EditBooking(int id, BookingViewModel bookingViewModel)
        {
            if (id != bookingViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var booking = MapBookingViewModelToBooking(bookingViewModel);
                _bookingService.UpdateBooking(booking);
                return RedirectToAction(nameof(Index));
            }
            return View(bookingViewModel);
        }

        [HttpGet]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _bookingService.GetBookingById(id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        [HttpPost, ActionName("DeleteBooking")]
        public IActionResult DeleteBookingConfirmed(int id)
        {
            _bookingService.DeleteBooking(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult BookingConfirmation()
        {
            return View();
        }

        private Booking MapBookingViewModelToBooking(BookingViewModel bookingViewModel)
        {
            return new Booking
            {
                Id = bookingViewModel.Id,
                FirstName = bookingViewModel.FirstName,
                LastName = bookingViewModel.LastName,
                Age = bookingViewModel.Age,
                MovieType = bookingViewModel.MovieType,
                Time = bookingViewModel.Time,
                Seat = bookingViewModel.Seat
            };
        }

        private BookingViewModel MapBookingToBookingViewModel(Booking booking)
        {
            return new BookingViewModel
            {
                Id = booking.Id,
                FirstName = booking.FirstName,
                LastName = booking.LastName,
                Age = booking.Age,
                MovieType = booking.MovieType,
                Time = booking.Time,
                Seat = booking.Seat
            };
        }
    }
}