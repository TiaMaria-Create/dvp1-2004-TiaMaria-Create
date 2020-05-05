using System;


// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Age Conversion

namespace DVP1
{
    public class CE4_AgeConvert
    {
        // Remember Public, Static methods are available to the entire solution.
        public static void AgeConvert()
        {
            //Welcome the user to the program and ask for their name?
            Console.WriteLine("Hello and Welcome to Age Convert! What is your name?");

            //Store the user's response
            string userName = Console.ReadLine();

            //verify users input
            while (string.IsNullOrEmpty(userName))

            {
                Console.WriteLine("Nothing was entered, Can you try again?");
                userName = Console.ReadLine();
            }


            //confirm the users input
            Console.WriteLine("Thank you {0} , how old are you? We are going to use this information to convert your age.", userName);

            //store the users response
            string userAge = Console.ReadLine();

            // Make sure the user is entering a valid age and convert to number data type
            bool choice = int.TryParse(userAge, out int ageConvert);
            //Create a while loop to ensure the user is entering a number between 0 - 5 only

            while (choice == false)

            {    //Tell the user that they've made a mistake
                Console.WriteLine("You entered an invalid selection. Please enter a number that corresponds to a selection above.");
                //Store the users new input
                userAge = Console.ReadLine();
                //Validate the users new input
                choice = int.TryParse(userAge, out ageConvert);

            }

            //Convert years to days, days to hours, hours to minutes, minutes to seconds
            double days = ageConvert * 365;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = hours * 60;

            //Tell the user their age
            Console.WriteLine("{0} you entered you are {1} years old.", userName, userAge);
            Console.WriteLine("At your next social gathering you can tell your friends that you are {0:N} days old, or {1:N} hours old. \r\nYou can also say you are {2:N} minutes old, or you can say you are {3:N} seconds old. Wow! Talk about a party trick.", days, hours, minutes, seconds);


            Console.WriteLine("======================================================");
            Console.WriteLine("Press Enter to go back to the main Menu.");
            Console.ReadKey();




        }

    }
}
