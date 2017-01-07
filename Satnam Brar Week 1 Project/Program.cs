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
            Console.WriteLine("\nPlease enter your age:\n");
            int age = int.Parse(Console.ReadLine());

            //prompt user to enter his or her month of birth
            Console.WriteLine("\nPlease enter your month of birth: (i.e. 1 for January, 12 for December):\n");
            int birthMonth = int.Parse(Console.ReadLine());

            //prompt user to enter his or her favorite ROYGBIV color
            //allows user to ask for help in case he or she is not familiar with ROYGBIV
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
            
            //prompt user to enter number of siblings
            Console.WriteLine("\nPlease enter number of siblings:\n");
            int numSiblings = int.Parse(Console.ReadLine());
            string numSiblings1 = numSiblings.ToString();

            Console.WriteLine(firstName1 + firstName + " " + lastName1 + lastName + " " + age + " " + birthMonth + " " + color + " " + numSiblings);
        }
    }
}
