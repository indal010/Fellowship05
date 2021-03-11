using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PINRegexTest
{
    class PINPattern
    {
        // re="^[1-9][0-9 ]{5}"; -> 90  12 ?
        // re="^" -> 123456 123 456 12 3456
         string Regex_Pincode = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
    }
}
