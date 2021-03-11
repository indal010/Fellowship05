using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatchingDemo
{
    class Patterns
    {
        public static string Regex_Pincode = "^[1-9][0-9]{5}$";

        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode,Regex_Pincode);
        }
    }
}
