using System;

namespace regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling a method 
            bool result = InputValidator.ValidatePhoneNumber("313-899-9999");
            Console.WriteLine("313-899-9999 is a phone number: " + result.ToString());
            result = InputValidator.ValidatePhoneNumber("313-899-999");
            Console.WriteLine("313-899-999 is a phone number: " + result.ToString());
            //(dd/mm/yyyy)
            result = InputValidator.ValidateDateFormat("26/10/2020");
            Console.WriteLine("26/10/2020 is a correct date format: " + result.ToString());
            Console.ReadLine();
        }
    }

}
