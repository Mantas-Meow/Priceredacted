﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Priceredacted.Tools
{
    static class Utils
    {
        public static string ProductsPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\Products.json";

        public static string UserDataPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).
            Parent.Parent.FullName + "\\DB\\UserData.json";

        public enum Shops {Default, Maxima, Lidl, Iki, Rimi, Norfa};
    }
}