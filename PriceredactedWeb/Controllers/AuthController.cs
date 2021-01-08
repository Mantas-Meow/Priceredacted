using Microsoft.AspNetCore.Mvc;
using PriceredactedWeb.DTOs;
using PriceredactedWeb.Models;
using PriceredactedWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceredactedWeb.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _AuthRepository;
        private readonly PriceredactedDBContext _context;
        public AuthController(IAuthRepository AuthRepository, PriceredactedDBContext context)
        {
            _AuthRepository = AuthRepository;
            _context = context;
        }

        [Route("api/Auth/Register")]
        [HttpPost]
        public IActionResult Register(UserRegisterDTO request)
        {
            var user = _AuthRepository.Register(request.Username , request.Password, request.Email);

            return user != false ? Ok(user) : NotFound();
        }


        [Route("api/Auth/UserByUsername/{username}")]
        [HttpGet]
        public ActionResult<UserDatum> GetUser(string username)
        {
            var User = _AuthRepository.GetUser(username);

            if (User == null)
            {
                return NotFound();
            }

            return User;
        }

        [Route("api/Auth/UserById/{userId:int}")]
        [HttpGet]
        public ActionResult<UserDatum> GetUser(int userId)
        {
            var User = _AuthRepository.GetUser(userId);

            if (User == null)
            {
                return NotFound();
            }

            return User;
        }

        [Route("api/Auth/DeleteUser/{userId:int}")]
        [HttpDelete]
        public IActionResult DeleteUser(int userId)
        {
            var User = _AuthRepository.DeleteUser(userId);

            return User != false ? Ok() : NotFound();
        }


        [Route("api/Auth/UpdatePassword")]
        [HttpPut]
        public IActionResult UpdatePassword(UpdatePasswordDTO data)
        {
            var User = _AuthRepository.UpdatePassword(data);

            return User != false ? Ok() : NotFound();
        }
    }
}
