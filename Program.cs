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
            string retireWhen = "";

            if (userAge % 2 == 0)
            {
                retireWhen = "will retire at age 55";
            }
            else
            {
                retireWhen = "will retire at age 48";
            }

            Console.WriteLine("In which month were you born?");
            string userMonthString = Console.ReadLine().ToLower();

            int userBirthMonthInt = 0;
            bool isValid = true;

            do
            {
                if (userMonthString == "january")
                {
                    userBirthMonthInt = 1;
                }
                else if (userMonthString == "february")
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
                    isValid = false;
                }
            } while (isValid == false);

            Console.WriteLine("Which of these colors is your favorite? Red, orange, yellow, green, blue, indigo, or violet?");
            string faveColorValue = Console.ReadLine().ToLower();
            string faveColorTransport = "";

            switch (faveColorValue)
            {
                case "red":
                    faveColorTransport = "full-size pickup truck";
                    break;
                case "orange":
                    faveColorTransport = "motorcycle";
                    break;
                case "yellow":
                    faveColorTransport = "Jeep";
                    break;
                case "green":
                    faveColorTransport = "Minivan";
                    break;
                case "blue":
                    faveColorTransport = "bicycle";
                    break;
                case "indigo":
                    faveColorTransport = "convertible";
                    break;
                case "violet":
                    faveColorTransport = "four door sedan";
                    break;
                default:
                    faveColorTransport = "you're walking everywhere";
                    break;
            }

            Console.WriteLine("Finally, how many siblings do you have?");
            int numSiblings = int.Parse(Console.ReadLine());

            string vacayHome = Console.ReadLine().ToLower();

            if (numSiblings == 0)
            {
                vacayHome = "Anne Arbor";
            }
            else if (numSiblings == 1)
            {
                vacayHome = "London";
            }
            else if (numSiblings == 2)
            {
                vacayHome = "Cancun";
            }
            else if (numSiblings == 3)
            {
                vacayHome = "Dublin";
            }
            else if (numSiblings > 3)
            {
                vacayHome = "Tampa";
            }
            else
            {
                vacayHome = "Boondocks";
            }

            Console.WriteLine(userName + " " + retireWhen);

            Console.ReadKey();
        }
    }
}
