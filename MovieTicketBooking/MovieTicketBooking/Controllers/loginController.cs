using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Interface;
using MovieTicketBooking.Models;
using MovieTicketBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        movieDBContext db;
        IJWTMangerRepository iJWTMangerRepository;
        public loginController(movieDBContext _db, IJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }



        [HttpPost]
        [Route("login")]
        public IActionResult Login(loginViewModels loginViewModel)
        {
            var token = iJWTMangerRepository.Authenicate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            loginViewModels login = new loginViewModels();
            login.UserName = registerViewModel.UserName;
            login.Password = registerViewModel.Password;
            var token = iJWTMangerRepository.Authenicate(login, true);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}


