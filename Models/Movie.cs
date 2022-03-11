using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Booking_API.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string MovieName { get; set; }
        public string DateTime { get; set; }
        public string Venue { get; set; }
        public string CinemaRoom { get; set; }
        public int NumberOfTickets { get; set; }
        public double TicketPrice { get; set; }

    }
}