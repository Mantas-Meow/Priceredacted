using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Priceredacted.Interfaces;
using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace Priceredacted.Logics
{
    class LoginWindowLogic : ILoginWindowLogic
    {
        public string AddUser(UserData user)
        {
            return UserDataValidation.AddUData(user, Tools.Utils.UserDataPath);
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
            return UserDataValidation.Login(user, pass, Tools.Utils.UserDataPath);
        }

        public bool RegisterUser(string pass1, string pass2, UserData user)
        {
            if (UserDataValidation.CheckPasswords(pass1, pass2))
            {
                SaveUser(user);
                return true;
            }
            return false;
        }

        public void SaveUser(UserData user)
        {
            string json = AddUser(user);
            System.IO.File.WriteAllText(Tools.Utils.UserDataPath, json);
        }
    }
}
