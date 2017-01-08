using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satnam_Brar_Week_1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter first name
            //entry will be converted to lower case, followed by capitalization of the first letter
            Console.WriteLine("Please enter your first name:\n");
            string firstName = Console.ReadLine();
            firstName = firstName.ToLower();
            string firstName1 = firstName.Substring(0, 1);
            firstName1 = firstName1.ToUpper();
            firstName = firstName.Remove(0, 1);      
            
            //prompt user to enter last name
            //entry will be converted to lower case, followed by capitalization of the first letter
            Console.WriteLine("\nPlease enter your last name:\n");
            string lastName = Console.ReadLine();
            lastName = lastName.ToLower();
            string lastName1 = lastName.Substring(0, 1);
            lastName1 = lastName1.ToUpper();
            lastName = lastName.Remove(0, 1);

            //prompt user to enter his or her age
            //an error will pop up and ask the user to enter age again if entry is <=0
                //however, this error can only work one time as there is no loop coded in, which we have not learned in class yet
            Console.WriteLine("\nPlease enter your age:\n");
            int age = int.Parse(Console.ReadLine());
            if (age <= 0)
            {
                Console.WriteLine("\nPlease enter a number greater than or equal to 1:\n");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
            }

            //create fortune based on age input
            int retire;
            if (age % 2 == 0)
            {
                retire = 65;
            }
            else
            {
                retire = 75;
            }

            //prompt user to enter his or her month of birth
            Console.WriteLine("\nPlease enter your month of birth: (i.e. 1 for January, 12 for December):\n");
            int birthMonth = int.Parse(Console.ReadLine());

            //create fortune based on birth month input
            int money;
            if (birthMonth >=1 && birthMonth <=4)
            {
                money = 500000;
            }
            else if (birthMonth > 4 && birthMonth <=8)
            {
                money = 900000;
            }
            else if (birthMonth > 9 && birthMonth <=12)
            {
                money = 50000;
            }
            else
            {
                money = 0;
            }


            //prompt user to enter his or her favorite ROYGBIV color
            //allows user to ask for help in case he or she is not familiar with ROYGBIV
                //if user enters help twice, there is no loop coded in to repeat output of help text
            //error output if color is not ROYGBIV. if user enter wrong color twice, there is no loop coded in to repeat error output
            Console.WriteLine("\nPlease enter your favorite ROYGBIV color:\n\nFor help, enter \"help\"\n");
            string help = "help";
            string color = Console.ReadLine();
            if (color.Equals(help, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("\nROYGBIV Colors\nR = Red\nO = Orange\nY = Yellow\nG = Green\nB = Blue\nI = Indigo\nV = Violet\n");
                Console.WriteLine("\nPlease enter your favorite ROYGBIV color:\n");
                string color1 = Console.ReadLine();
                color = color1;
            }
            if (color.Equals("red", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "red";
            }
            else if (color.Equals("orange", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "orange";
            }
            else if (color.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "yellow";
            }
            else if (color.Equals("green", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "green";
            }
            else if (color.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "blue";
            }
            else if (color.Equals("indigo", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "indido";
            }
            else if (color.Equals("violet", StringComparison.CurrentCultureIgnoreCase))
            {
                color = "violet";
            }
            else 
            {
                Console.WriteLine("\nPlease enter a valid ROYGBIV color:\n");
                string color2 = Console.ReadLine();
                color = color2;
            }

            //creates fortune based on favorite color
            string whip;
            switch (color)
            {
                case "red":
                    whip = "Lambo";
                    break;
                case "orange":
                    whip = "Toyota Camry";
                    break;
                case "yellow":
                    whip = "Bentley";
                    break;
                case "green":
                    whip = "Subaru";
                    break;
                case "blue":
                    whip = "Ducati";
                    break;
                case "indigo":
                    whip = "Tesla";
                    break;
                case "violet":
                    whip = "Volkswagen";
                    break;
                default:
                    whip = "1993 Honda Civic";
                    break;
            }

            //prompt user to enter number of siblings
            Console.WriteLine("\nPlease enter number of siblings:\n");
            int numSiblings = int.Parse(Console.ReadLine());
            string numSiblings1 = numSiblings.ToString();

            //creates fortune based on number of siblings
            string vacaHome;
            if (numSiblings == 0)
            {
                vacaHome = "Paris";
            }
            else if (numSiblings == 1)
            {
                vacaHome = "Barcelona";
            }
            else if (numSiblings == 2)
            {
                vacaHome = "Venice";
            }
            else if (numSiblings == 3)
            {
                vacaHome = "Madrid";
            }
            else if (numSiblings > 3)
            {
                vacaHome = "Miami";
            }
            else
            {
                vacaHome = "Antarctica";
            }

            //Write out fortune based on user input
            Console.WriteLine("\nBased on the answers, the crystal ball shows...\n...\n...\n...\n\n" + firstName1 + firstName + " " + lastName1 + lastName + " will retire at the age of " + retire + " with $" + money + ".00 in the bank, a vacation home in " + vacaHome + ", and a " + whip + ".\n");
        }
    }
}
