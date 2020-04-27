using System;


// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Main Method / Initiates Program.   
// Synopsis: Provides a means for the user to select and run any of the other completed coding challenges.
// As we complete each challenge, this will offer a way for the user to run it. 

namespace DVP1
{
    public class CE5_TempConvert
    {
        // Remember Public, Static methods are available to the entire solution.
        public static void TempConvert()
        {
            //Welcome the user to the program and introduce the program options
            Console.WriteLine("Welcome to the Temperature Conversion Program. Would you like to...");
            //Introduce the option to calculate fahrenheit to celsius
            Console.WriteLine("(1) Convert temperature from Fahrenheit to Celsius.");
            //Introduce the option to calculate celsius to fahrenheit
            Console.WriteLine("(2) Convert temperature from Celsius to Fahrenheit.");

            //capture and store the users input into a variable
            string conversionSelection = Console.ReadLine();

            // Make sure the user entered a valid selection
            bool choice = int.TryParse(conversionSelection, out int userOption);

            //Create a while loop to ensure the user entered selection 1 or 2 only
            while (choice == false || userOption > 2 || userOption < 1)

            {    //Tell the user that they've made a mistake
                Console.WriteLine("You entered an invalid selection. Please enter a number that corresponds to a selection above.");
                //Store the users new input
                conversionSelection = Console.ReadLine();
                //Validate the users new input
                choice = int.TryParse(conversionSelection, out userOption);

            }

           
        }
    }
}