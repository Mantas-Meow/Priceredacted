using Priceredacted.Exceptions;
using Priceredacted.Properties;
﻿using Priceredacted.Logics;
using System;
using System.Windows.Forms;

namespace Priceredacted.Controllers
{
    class LoginWindowController
    {
        public int i = 0;
        private LoginWindowLogic loginLogic;
        public LoginWindowController()
        {
            loginLogic = new LoginWindowLogic();
        }
        public void LoadMainWindow()
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
        public void RegisterUser(string username, string email, string password1, string password2)
        {
            UserData newUser;
            try
            {
                newUser = loginLogic.CreateNewUser(username, email, password1);
            }
            catch (Exception e)
            {
                MessageBox.Show("User was not created!");
                return;
            }
            try
            {
                if (loginLogic.RegisterUser(username, email, password1, password2, newUser))
                {
                    MessageBox.Show("User registered!");
                    i = 1;
                }
            }
            catch (PasswordValidationException)
            {
                MessageBox.Show("Passwords do not match. Please check and try again.");
                i = 0;
            }
            catch(EmailValidationException)
            {
                MessageBox.Show("The entered email is not valid.");
                i = 0;
            }
            catch(UsernameValidationException)
            {
                MessageBox.Show("Username is taken or not valid. Username must be atleast 3 characters long.");
                i = 0;
            }
        }
        public void LoginUser(string username, string pass, Form logInForm)
        {
            if (!loginLogic.LogInUser(username, pass))
            {
                MessageBox.Show("Wrong username or passowrd!");
            }
            else
            {
                logInForm.Hide();
                LoadMainWindow();
            }
        }
    }
}
