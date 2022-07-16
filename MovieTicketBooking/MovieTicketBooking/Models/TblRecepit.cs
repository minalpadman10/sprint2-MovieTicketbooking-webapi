using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class TblRecepit
    {
        public int Id { get; set; }
        public int? NoOfTickets { get; set; }
        public string Theatre { get; set; }
        public string Movie { get; set; }
        public int? Date { get; set; }
        public decimal? Show { get; set; }
        public decimal? Fare { get; set; }
    }
}
