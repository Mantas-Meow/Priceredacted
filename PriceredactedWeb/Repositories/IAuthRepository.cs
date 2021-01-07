using PriceredactedWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PriceredactedWeb.Repositories
{
    public interface IAuthRepository
    {
        public bool Register(string username, string password, string email);
        public UserDatum GetUser(string userEmail);
        public UserDatum GetUser(int userId);
        public bool DeleteUser(int userId);
    }
}
