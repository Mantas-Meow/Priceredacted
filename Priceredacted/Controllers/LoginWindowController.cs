using Priceredacted.Exceptions;
using Priceredacted.Properties;
﻿using Priceredacted.Logics;
using System;
using System.Windows.Forms;

namespace Priceredacted.Controllers
{
    class LoginWindowController
    {
        private LoginWindowLogic loginLogic;
        public LoginWindowController()
        {
            loginLogic = new LoginWindowLogic();
        }
        public void LoadMainWindow(UserData user)
        {
            //MainWindow main = new MainWindow(user);
            //main.Show();
        }
        public bool RegisterUser(string username, string email, string password1, string password2, Guid Id)
        {
            UserData newUser;
            try
            {
                newUser = loginLogic.CreateNewUser(username, email, password1, Id);
            }
            catch (Exception e)
            {
                MessageBox.Show("User was not created!");
                return false;
            }
            try
            {
                if (loginLogic.CheckRegisterUser(username, email, password1, password2, newUser, Id))
                {
                    MessageBox.Show("User registered!");
                    return true;
                }
                
            }
            catch (PasswordValidationException)
            {
                MessageBox.Show("Passwords do not match. Please check and try again.");
                return false;
            }
            catch(EmailValidationException)
            {
                MessageBox.Show("The entered email is not valid.");
                return false;
            }
            catch(UsernameValidationException)
            {
                MessageBox.Show("Username is taken or not valid. Username must be atleast 3 characters long.");
                return false;
            }
            return false;
        }
        public void LoginUser(string username, string pass, Form logInForm)
        {
            UserData user = loginLogic.LogInUser(username, pass);
            if (user == null)
            {
                MessageBox.Show("Wrong username or password!");
            }
            else
            {
                user.Password = null;
                logInForm.Hide();
                LoadMainWindow(user);
            }
        }
    }
}
