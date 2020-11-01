using Priceredacted.Logics;
using Priceredacted.Search;
using System;
using System.Collections.Generic;
using System.Text;
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
                if (loginLogic.RegisterUser(password1, password2, newUser))
                {
                    MessageBox.Show("User registered!");
                }
                else MessageBox.Show("Check passwords");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while registering new user!");
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
