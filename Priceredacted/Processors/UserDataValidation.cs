using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Search;
using Priceredacted.UI;

namespace Priceredacted.Processors
{
    class AddUserData
    {
        public static string AddUData(UserData dataToBeAdded)
        {
            List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(LogInForm.path));
            if (Data == null)
            {
                Data = new List<UserData>();
            }
            Data.Add(dataToBeAdded);
            return JsonConvert.SerializeObject(Data.ToArray());
        }
        public static bool CheckPasswords(string str1, string str2)
        {
            return str1 == str2;
        }
        public static bool Login(string str1, string str2)
        {
            List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(LogInForm.path));
            foreach(UserData ud in Data)
            {
                if (ud.Username == str1 && ud.Password == str2)
                    return true;
            }
            return false;
        }
    }
}
