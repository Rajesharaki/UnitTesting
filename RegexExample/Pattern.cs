using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExample
{
    public class Pattern
    {

        //Rajesha-raki.86_13@gmail.com

        //rajesharaki8613@gmail.in

        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";

        public static string Regex_MobNo = @"^[6789]\d{9}$"; 

        public static string Regex_Email = @"^[A-Z \. _ \- a-z 0-9]{3,}[@][a-z]{3,}.?(com)$";

        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }

        public bool ValidatePinCode(string pincode) 
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }

        public bool ValidateMobNo(string MobNo)
        {
            return Regex.IsMatch(MobNo, Regex_MobNo);
        }
      
    }
}
