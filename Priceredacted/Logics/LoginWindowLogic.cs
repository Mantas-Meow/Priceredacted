using Priceredacted.Exceptions;
using Priceredacted.Interfaces;
using Priceredacted.Processors;
using Priceredacted.Properties;
using System.Collections.Generic;
using System;

namespace Priceredacted.Logics
{
    class LoginWindowLogic : ILoginWindowLogic
    {
        public void AddUser(UserData user)
        {
            List<UserData> allUsers = LoadUsers();
            if (allUsers == null)
            {
                allUsers = new List<UserData>();
            }
            allUsers.Add(user);
            DataProcessor.SaveJson(allUsers, Tools.Utils.UserDataPath);
        }

        public UserData CreateNewUser(string username, string email, string password, Guid Id)
        {
            return new UserData()
            {
                Username = username,
                Email = email,
                Password = password,
                Id = Guid.NewGuid()
            };
        }

        public List<UserData> LoadUsers()
        {
            return (List<UserData>) DataProcessor.LoadJson<UserData>(Tools.Utils.UserDataPath);
        }

        public UserData LogInUser(string user, string pass)
        {
            return UserDataValidation.Login(user, pass, LoadUsers());
        }

        public bool CheckRegisterUser(string username, string email, string pass1, string pass2, UserData user, Guid Id)
        {
            if (!UserDataValidation.CheckPasswords(pass1, pass2))
                throw new PasswordValidationException();
            else if (!UserDataValidation.UsernameAvailability(username, LoadUsers()))
                throw new UsernameValidationException();
            else if (!UserDataValidation.EmailValidation(email))
                throw new EmailValidationException();
            else
            {
                AddUser(user);
                return true;
            }
        }
    }
}
