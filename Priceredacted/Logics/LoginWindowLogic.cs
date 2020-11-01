using Newtonsoft.Json;
using Priceredacted.Interfaces;
using Priceredacted.Processors;
using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Logics
{
    class LoginWindowLogic : ILoginWindowLogic
    {
        public string AddUser(UserData user)
        {
            
        }

        public UserData CreateNewUser(string username, string email, string password)
        {
            return new UserData()
            {
                Username = username,
                Email = email,
                Password = password
            };
        }

        public List<UserData> LoadUsers(string path)
        {
            return JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
        }

        public bool LogInUser(string user, string pass)
        {
            return UserDataValidation.Login(user, pass);
        }

        public bool LogInUser()
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser()
        {
            if (UserDataValidation.CheckPasswords(RegPassword_textbox.ToString(), RegRPassword_textbox.ToString()))
            {
                string json = UserDataValidation.AddUData(ud);
                System.IO.File.WriteAllText(path, json);
                MessageBox.Show("User registered");
            }
        }

        public void SaveUser(string json)
        {
            throw new NotImplementedException();
        }
    }
}
