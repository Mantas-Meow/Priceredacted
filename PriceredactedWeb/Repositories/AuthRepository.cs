using PriceredactedWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PriceredactedWeb.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly PriceredactedDBContext _context;
        public AuthRepository(PriceredactedDBContext context)
        {
            _context = context;
        }
        public UserDatum Register(string username, string password, string email)
        {
            Random rnd = new Random();


            UserDatum user = new UserDatum()
            {
                Username = username,
                Email = email,
                Password = password,
                Id = rnd.Next(1000)
            };
            _context.Add(user);
            _context.SaveChanges();

            return user;
        }
    }
}
