using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Interfaces
{
    interface ILoginWindowLogic
    {
        public UserData CreateNewUser(string username, string email, string password);
        public string AddUser(UserData user);
        public void SaveUser(UserData user);
        public List<UserData> LoadUsers(string path);
        public bool RegisterUser(string username, string email, string pass1, string pass2, UserData user);
        public bool LogInUser(string user, string pass);
    }
}
