using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Search;
using Priceredacted.UI;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Priceredacted.Processors
{
    class UserDataValidation
    {
        public static string AddUData(UserData dataToBeAdded, string path)
        {
            List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
            if (Data == null)
            {
                Data = new List<UserData>();
            }
            Data.Add(dataToBeAdded);
            return JsonConvert.SerializeObject(Data.ToArray(), Formatting.Indented);
        }
        public static bool CheckPasswords(string str1, string str2)
        {
            string strRegex = @"^[^\s]{4,15}$";
            Regex re = new Regex(strRegex);
            if (str1 == str2 && re.IsMatch(str1))
                return true;
            else
            {
                return false;
                throw new ValidationException("Please check your passwords");
            }
        }
        public static bool Login(string str1, string str2, string path)
        {
            List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
            foreach(UserData ud in Data)
            {
                if (ud.Username == str1 && ud.Password == str2)
                    return true;
            }
            return false;
        }
        public static bool EmailValidation(string str1)
        {
            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str1))
                return true;
            else
            {
                return false;
            } 
        }
        public static bool UsernameAvailability(string str1, string path)
        {
            List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
            string strRegex = @"^[^\s]{3,15}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str1))
            {
                foreach (UserData ud in Data)
                {
                    if (ud.Username == str1)
                    {
                        return false;
                    }
                        
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
