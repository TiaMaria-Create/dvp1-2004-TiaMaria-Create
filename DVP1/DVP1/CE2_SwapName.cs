using System;
using System.Collections;
using System.Linq;
using System.Text;


// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Main Method / Initiates Program.   
// Synopsis: This is a string exercise that reverse the order of user entered information.

namespace DVP1
{
    public class CE2___SwapName
    {
        // Remember Public, Static methods are available to the entire solution.
        public static void SwapName()
        {
            //Welcome the user to the program
            Console.WriteLine("Welcome to a game of SwapName!");
            //Prompt the user for their first and last name
            Console.WriteLine("To get started, what is your first name?");
            string userInputFirst = Console.ReadLine().Trim();


            while (string.IsNullOrEmpty(userInputFirst))

            {
                Console.WriteLine("Nothing was entered, Can you try again?");
                userInputFirst = Console.ReadLine();


            }


            Console.WriteLine("Thank you {0}, What is your last name?", userInputFirst);
            string userInputLast = Console.ReadLine().Trim();


            while (string.IsNullOrEmpty(userInputLast))

            {
                Console.WriteLine("Hey you didn't enter anything, can you try again?");
                userInputLast = Console.ReadLine();

            }




            //Create a string variable that will push and retrieve the paramenters from the reverse method
            string reversedName = ReverseName(userInputFirst, userInputLast);

            //Console.WriteLine("Excellent {0} {1}! Now if reversed your name would be {1} {0}.", userInputFirst, userInputLast);

            Console.WriteLine("Excellent {0} {1}! Now if reversed your name would be {2}.", userInputFirst, userInputLast, reversedName);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }


        public static string ReverseName(string first, string last)

        {
            string reversed = string.Concat(last, ", ", first);
            return reversed;
        }

    }
}