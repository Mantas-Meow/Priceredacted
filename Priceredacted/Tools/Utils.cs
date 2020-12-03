using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Priceredacted.Tools
{
    static public class Utils
    {
        public static string ProductsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Products.json";

        public static string UserDataPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\UserData.json";

        public static string ReceiptsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Receipts.json";
        public enum Shops {Default, Maxima, Lidl, Iki, Rimi, Norfa};
    }
}
