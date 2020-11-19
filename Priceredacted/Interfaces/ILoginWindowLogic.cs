using Priceredacted.Properties;
using System.Collections.Generic;

namespace Priceredacted.Interfaces
{
    interface ILoginWindowLogic
    {
        public UserData CreateNewUser(string username, string email, string password);
        public void AddUser(UserData user);
        public List<UserData> LoadUsers();
        public bool RegisterUser(string username, string email, string pass1, string pass2, UserData user);
        public bool LogInUser(string user, string pass);
    }
}
