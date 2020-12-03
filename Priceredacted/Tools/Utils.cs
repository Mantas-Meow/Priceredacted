using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Configuration;

namespace Priceredacted.Tools
{
    static public class Utils
    {
        /*public static string ProductsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Products.json";*/
        public static string ProductsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
             Parent.Parent.FullName + ConfigurationManager.AppSettings["ProductsPath"];

        public static string UserDataPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
             Parent.Parent.FullName + ConfigurationManager.AppSettings["UserDataPath"];
        //public static string UserDataPath = ConfigurationManager.AppSettings["UserDataPath"];

        /*public static string ReceiptsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Receipts.json";*/
        public static string ReceiptsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
             Parent.Parent.FullName + ConfigurationManager.AppSettings["ReceiptsPath"];

        public static string ItemsInReceiptPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\ItemsInReceipt.json";

        public enum Shops {Default, Maxima, Lidl, Iki, Rimi, Norfa};
    }
}
