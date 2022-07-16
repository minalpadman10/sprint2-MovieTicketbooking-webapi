using MovieTicketBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Interface
{
   public interface IJWTMangerRepository
    {
        Tokens Authenicate(loginViewModels users, bool IsRegister);
    }
}
