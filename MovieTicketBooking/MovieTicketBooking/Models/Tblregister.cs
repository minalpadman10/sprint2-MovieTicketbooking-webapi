using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Tblregister
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Mobilenumber { get; set; }
    }
}
