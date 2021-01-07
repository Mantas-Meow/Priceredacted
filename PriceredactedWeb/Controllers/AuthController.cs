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

        [HttpPost("Register")]
        public IActionResult Register(UserRegisterDTO request)
        {
            var user = _AuthRepository.Register(request.Username , request.Password, request.Email);

            return user != null ? Ok(user) : NotFound();
        }


        [Route("api/Auth/UserByEmail/{userEmail}")]
        [HttpGet]
        public ActionResult<UserDatum> GetUser(string userEmail)
        {
            var User = _AuthRepository.GetUser(userEmail);

            if (User == null)
            {
                return NotFound();
            }

            return User;

            //var User = _context.UserData.First(a => a.Email == userEmail);//_context.UserData.Find(userEmail);

            //return User != null ? User : NotFound();
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

            //var User = _context.UserData.First(a => a.Email == userEmail);//_context.UserData.Find(userEmail);

            //return User != null ? User : NotFound();
        }





















        /*[HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepo.Login(
                request.Username, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        // GET: api/<AuthController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuthController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
