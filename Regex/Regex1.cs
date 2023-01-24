using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Programs
{
    internal class Regex1
    {
      
        public void FirstName()
        {  
            Console.WriteLine("Enter Firts Name");
            string data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid First Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid First Name");
                Console.ResetColor();
            }
        }
        public void LastName()
        {
            Console.WriteLine("Enter first name");
            string data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Last Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Last Name");
                Console.ResetColor();
            }
        }
        public void EmailId()
        {
            Console.WriteLine("Enter Email ID");
            string data = Console.ReadLine();
            string pattern = "^[A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Email ID");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Email ID");
                Console.ResetColor();
            }
        }
        public void PhoneNumber()
        {
            Console.WriteLine("Enter Phone Number");
            string data = Console.ReadLine();
            string pattern = "^[6-9]{2}[0-9]{8}?$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Phone Number");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Phone Number");
                Console.ResetColor();
            }
        }
    }
}
