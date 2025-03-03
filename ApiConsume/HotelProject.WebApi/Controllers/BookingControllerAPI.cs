﻿using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingControllerAPI : Controller
    {
        private readonly IBookingService _booking;
        public BookingControllerAPI(IBookingService serviceService)
        {
            _booking = serviceService;
        }


        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _booking.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _booking.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var vbalues = _booking.TGetById(id);
            _booking.TDelete(vbalues);
            return Ok();
        }


        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking book)
        {
            _booking.TUpdate(book);
            return Ok();
        }



        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _booking.TGetById(id);
            return Ok(values);
        }

        [HttpPut("aaaaaaa")]
        public IActionResult aaaaaaa(Booking booking)
        {
            _booking.TBookinStatusChangeApproved(booking);
            return Ok();

        }
        [HttpPut("bbbbbb")]
        public IActionResult bbbbbb(int id)
        {
            _booking.TBookinStatusChangeApproved2(2);
            return Ok();

        }

    }
}
