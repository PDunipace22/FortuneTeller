using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared variables within the lines of code

            Console.WriteLine("What is your fist name?");
            string first = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birth month?");
            double birthMonth = double.Parse(Console.ReadLine());
            Console.WriteLine("How many siblings do you have?");
            int sibling = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select your favorite color from the following acronym:ROYGBIV, or enter help");
            string color = Console.ReadLine().ToLower();
            if (color == "help")//Set to show the list of colors and then asks the user to select their favorite color.
            {
                Console.WriteLine(" Please enter R = Red, O = Orange, Y = Yellow, G = Green, B = Blue, I = Indigo, V = Violet");
                Console.WriteLine("Please select your favorite color from the following acronym:ROYGBIV.");
                color = Console.ReadLine().ToLower();
            }
            //Take age and find the remainder and then add the remainder from the age to find years until retirement
            int retirementAge = 0;
            if (age % 2 ==0)
            {
                retirementAge = age + 20;
            }
            else
            {
                retirementAge = age + 25;
            }
            //Changes the location based on how many siblings
            string vacationCity = string.Empty;
            switch (sibling)
            {
                case (0):
                    vacationCity = "Seattle, Washington";
                    break;
                case (1):
                    vacationCity = "London, England";
                    break;
                case (2):
                    vacationCity = "Tampa Bay, Florida";
                    break;
                case (3):
                    vacationCity = "Sydney, Australia";
                    break;
                default:
                    if(sibling > 3)
                    {
                        vacationCity = "Las Vegas, Nevada";
                    }
                    else
                    {
                        vacationCity = "the Sahara Desert";
                    }
                    break;
            }
            // changes the mode of transportation based on the color chosen
            string transportation = string.Empty;
            switch (color)
            {
                case ("r"):
                    transportation = "Ford Mustang";
                    break;
                case ("o"):
                    transportation = "Camper";
                    break;
                case ("y"):
                    transportation = "Unicycle";
                    break;
                case ("g"):
                    transportation = "Chevy Camaro";
                    break;
                case ("b"):
                    transportation = "jet pack";
                    break;
                case ("i"):
                    transportation = "Snowmobile";
                    break;
                default:
                    transportation = "hang glider";
                    break;
            }
            // The amount of money in the bank changes based on the group of months
            string moneyInBank = string.Empty;
            switch (birthMonth)
            { 
                case (1):
                case (2):
                case (3):
                case (4):
                    moneyInBank = "$4,000,000,000";
                    break;
                case (5):
                case (6):
                case (7):
                case (8):
                    moneyInBank = "$25,0000";
                    break;
                case (9):
                case (10):
                case (11):
                case (12):
                    moneyInBank = "$3,000,000";
                    break;
                default:
                    moneyInBank = "$0";
                    break;
            }
            Console.WriteLine("{0} years.", retirementAge);
            Console.WriteLine(first + " " + last + " will retire in " + retirementAge + " years with " + moneyInBank + " in the bank, a vacation home in " + vacationCity+ " and a " +transportation);
           


           
        }
    }
}
