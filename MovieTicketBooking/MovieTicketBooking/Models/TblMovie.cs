using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class TblMovie
    {
        public int Id { get; set; }
        public string SelectMovie { get; set; }
        public string SelectTheater { get; set; }
        public int? SelectDate { get; set; }
        public int? SelectTime { get; set; }
        public int? NoOfTickets { get; set; }
    }
}
