using Priceredacted.Logics;
using System;
using System.Collections.Generic;
using System.Text;

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
        public void RegisterUser(string username, string email, string password)
        {

        }
    }
}
