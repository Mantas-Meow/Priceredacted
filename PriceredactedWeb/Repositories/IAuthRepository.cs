using PriceredactedWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceredactedWeb.Repositories
{
    public interface IAuthRepository
    {
        public UserDatum Register(string username, string password, string email);
    }
}
