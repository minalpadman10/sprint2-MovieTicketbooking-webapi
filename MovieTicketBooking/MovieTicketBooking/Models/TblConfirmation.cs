using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class TblConfirmation
    {
        public int Id { get; set; }
        public int? NoOfTickets { get; set; }
        public string TheaterName { get; set; }
        public string MovieName { get; set; }
        public int? Date { get; set; }
        public int? Time { get; set; }
        public int? Fare { get; set; }
    }
}
