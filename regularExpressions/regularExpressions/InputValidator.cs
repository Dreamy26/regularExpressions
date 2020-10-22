using System;
using System.Text.RegularExpressions;

namespace regularExpressions
{
    public static class InputValidator
    {
        //req1
        //all methods return something and should start with a Cap
        public static bool ValidateName(string userName)
        {
            //checking if not empty or not void w/max lenght of 30
            if (userName.Length < 31 && !string.IsNullOrEmpty(userName) && char.IsUpper(userName[0]))
            {
                return true;
            }
            return false;
        }
        //req2
        public static bool ValidateEmail(string userEmail)
        {
            // https://regexr.com
            Regex regex = new Regex(@"[\w._%+-]{5,30}@[\w.-]{5,10}\.[a-zA-Z]{2,3}");
            return regex.Match(userEmail).Success;
        }
        //req3
        public static bool ValidatePhoneNumber(string userPhoneNumber)
        {
            // https://regexr.com
            Regex regex = new Regex(@"[0-9]{3}[-][0-9]{3}[-][0-9]{4}");
            return regex.Match(userPhoneNumber).Success;
            //call method w/out user interaction
            //test email
        }
        //req4
        public static bool ValidateDateFormat(string dateFormat)
        {
            // https://regexr.com
            //(dd/mm/yyyy)
            Regex regex = new Regex(@"^(3[01]|[12][0-9]|[1-9])[/](1[0-2]|[1-9])[/](\d{4})");
            return regex.Match(dateFormat).Success;
        }
    }


}
