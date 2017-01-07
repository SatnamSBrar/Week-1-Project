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
            //This code will prompt user to enter first name
            //entry will be converted to lower case, followed by capitalization of the first letter
            Console.WriteLine("Please enter your first name:\n");
            string firstName = Console.ReadLine();
            firstName = firstName.ToLower();
            string firstName1 = firstName.Substring(0, 1);
            firstName1 = firstName1.ToUpper();
            firstName = firstName.Remove(0, 1);

            //This code will prompt user to enter last name
            //entry will be converted to lower case, followed by capitalization of the first letter
            Console.WriteLine("Please enter your first name:\n");
            string lastName = Console.ReadLine();
            lastName = lastName.ToLower();
            string lastName1 = lastName.Substring(0, 1);
            lastName1 = lastName1.ToUpper();
            lastName = lastName.Remove(0, 1);
        }
    }
}
