using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinRegex2
{
    class Pattern
    {
        //aaaaaa, sdfg45// pincode -> 6digi , 234 678   345654 [ ]
        //string Regex_Pincode="^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        // string Regex_Pincode = "^[a-z0-9A-Z]+[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}$";
        string Regex_Pincode="^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        //string Regex_Pincode = " ^(?!invalid)(.(?!invalid))*$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
    }
}
