using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_revisit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("In which month were you born?");
            string userMonthString = Console.ReadLine().ToLower();

            int userBirthMonthInt;

            if(userMonthString == "january") 
            {
                userBirthMonthInt = 1;
            }
            else if(userMonthString == "february")
            {
                userBirthMonthInt = 2;
            }
            else if (userMonthString == "march")
            {
                userBirthMonthInt = 3;
            }
            else if (userMonthString == "april")
            {
                userBirthMonthInt = 4;
            }
            else if (userMonthString == "may")
            {
                userBirthMonthInt = 5;
            }
            else if (userMonthString == "june")
            {
                userBirthMonthInt = 6;
            }
            else if (userMonthString == "july")
            {
                userBirthMonthInt = 7;
            }
            else if (userMonthString == "august")
            {
                userBirthMonthInt = 8;
            }
            else if (userMonthString == "september")
            {
                userBirthMonthInt = 9;
            }
            else if (userMonthString == "october")
            {
                userBirthMonthInt = 10;
            }
            else if (userMonthString == "november")
            {
                userBirthMonthInt = 11;
            }
            else if (userMonthString == "december")
            {
                userBirthMonthInt = 12;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
