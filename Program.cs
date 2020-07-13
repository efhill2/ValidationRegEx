using System;
using System.IO.Pipes;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Validation_with_RegEx
{
    class Program
    {
        public static bool ValidName(string name)
        {
            while (!Regex.IsMatch(name, @"(^[A-Za-z]{1,30}\s[A-Za-z]{1,30})"))
            {
                Console.WriteLine("Name Not Valid!");
                break;
            }
            if (Regex.IsMatch(name, @"(^[A-Za-z]{1,30}\s[A-Za-z]{1,30})"))
            {
                Console.WriteLine("Name Valid");
            }
            return (true);

        }

        public static bool ValidEmail(string email)
        {
            while (!Regex.IsMatch(email, @"([A-Za-z]{5,30}\@[A-Za-z]{5,10}\.[A-Za-z0-9]{2,3})"))
            {
                Console.WriteLine("Email Not Valid!");
                break;
            }
            if (Regex.IsMatch(email, @"([A-Za-z]{5,30}\@[A-Za-z]{5,10}\.[A-Za-z0-9]{2,3})"))
            {
                Console.WriteLine("Valid");
            }
            return (true);
        }

        public static bool ValidPhoneNumber(string phoneNumber)
        {
            while ((!Regex.IsMatch(phoneNumber, @"(\([0-9]{3}\)\-[0-9]{3}\-[0-9]{4})")) & ((!Regex.IsMatch(phoneNumber, @"([0-9]{3}\.[0-9]{3}\.[0-9]{4})"))))
            {
                Console.WriteLine("Phone Number Not Valid");
                break;
            }
            if ((Regex.IsMatch(phoneNumber, @"(\([0-9]{3}\)\-[0-9]{3}\-[0-9]{4})")) | ((Regex.IsMatch(phoneNumber, @"([0-9]{3}\.[0-9]{3}\.[0-9]{4})"))))
            {
                Console.WriteLine("Valid");
            }
            return (true);
        }

        public static bool ValidDate(string date)
        {
            while (!Regex.IsMatch(date, @"(([0-1]{1})([0-9]{1})\/([0-3]{1,3})([0-9]{1,31})\/([0-9]{4}))"))
            {
                Console.WriteLine("Date Not Valid");
                break;
            }
            if (Regex.IsMatch(date, @"(([0-1]{1})([0-9]{1})\/([0-3]{1,3})([0-9]{1,31})\/([0-9]{4}))"))
            {
                Console.WriteLine("Valid");
            }
            return (true);
        }

        public static bool ValidHTML(string html)
        {
            while(!Regex.IsMatch(html, @"(\<[A-za-z]{1}\>)\s*(\<\/[A-Za-z]{1}\>)"))
            {
                Console.WriteLine("HTML Not Valid"!);
                break;
            }
            if (Regex.IsMatch(html, @"(\<[A-za-z]{1}\>)\s*(\<\/[A-Za-z]{1}\>)"))
            {
                Console.WriteLine("Valid");
            }
            return (true);
        }


        static void Main(string[] args)
        {
            //Variables

            string ans, name , email , phoneNumber , date , html;

            do
            {
                Console.WriteLine("Please enter name");
                name = Console.ReadLine();
                bool input0 = ValidName(name);

                Console.WriteLine("Please enter email");
                email = Console.ReadLine();
                bool input1 = ValidEmail(email);

                Console.WriteLine("Please enter phone number");
                phoneNumber = Console.ReadLine();
                bool input2 = ValidPhoneNumber(phoneNumber);

                Console.WriteLine("Please enter date");
                date = Console.ReadLine();
                bool input3 = ValidDate(date);

                Console.WriteLine("Please enter HTML elements");
                html = Console.ReadLine();
                bool input4 = ValidHTML(html);

                Console.WriteLine("Would like to fill out the fields again? (y/n)");
                ans = Console.ReadLine().ToLower();

            } while (ans == "y");
        }
    }
}
