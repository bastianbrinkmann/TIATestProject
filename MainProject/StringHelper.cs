﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class StringHelper
    {
        public string ConcatStrings(string a, string b)
        {
            string result = string.Concat(a, b);
            var x = "";
            return result;
        }

        public int IndexOfInString(string a, string b)
        {
            int result = a.IndexOf(b);
            return result;
        }

        public bool EmptyOrNull(string a)
        {
            return string.IsNullOrEmpty(a);
        }

        public int Compare(string a, string b)
        {
            return string.Compare(a, b);
        }

        public string Test(string a, string b)
        {
            return a + " _ " + b;
        }
    }
}
