using System.Collections.Generic;
using Priceredacted.Properties;
using System.Text.RegularExpressions;

namespace Priceredacted.Processors
{
    class UserDataValidation
    {
        public static bool CheckPasswords(string str1, string str2)
        {
            string strRegex = @"^[^\s]{4,15}$";
            Regex re = new Regex(strRegex);
            return (str1 == str2 && re.IsMatch(str1));
        }
        public static UserData Login(string str1, string str2, List<UserData> allUsers)
        {
            foreach (UserData ud in allUsers)
            {
                if (ud.Username == str1 && ud.Password == str2)
                    return ud;
            }
            return null;
        }
        public static bool EmailValidation(string str1)
        {
            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex re = new Regex(strRegex);
            return re.IsMatch(str1);
        }
        public static bool UsernameAvailability(string str1, List<UserData> allUsers)
        {
            string strRegex = @"^[^\s]{3,15}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str1))
            {
                foreach (UserData ud in allUsers)
                {
                    if (ud.Username == str1)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}
