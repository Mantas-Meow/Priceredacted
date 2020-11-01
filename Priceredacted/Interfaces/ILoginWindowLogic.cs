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
        public void SaveUser(string json);
        public List<UserData> LoadUsers(string path);
        public bool RegisterUser();
        public bool LogInUser();
    }
}
