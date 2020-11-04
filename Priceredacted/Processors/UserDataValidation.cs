using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using Priceredacted.Properties;
using Priceredacted.UI;

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
            return JsonConvert.SerializeObject(Data.ToArray());
        }
        public static bool CheckPasswords(string str1, string str2)
        {
            return str1 == str2;
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
    }
}
