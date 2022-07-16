using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class TblPayment
    {
        public int Id { get; set; }
        public int? CreditCard { get; set; }
        public int? DebitCard { get; set; }
        public int? Netbanking { get; set; }
        public int? Upiid { get; set; }
    }
}
