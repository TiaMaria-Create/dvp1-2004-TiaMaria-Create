using System;

// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Main Method / Initiates Program.   
// Synopsis: Provides a means for the user to select and run any of the other completed coding challenges.
// As we complete each challenge, this will offer a way for the user to run it. 



namespace DVP1
{
    public class Validation
    {
        public Validation()
        {
        }

        // String Required
        public static string ValidateUserInput(string message)
        {

            Console.Write(message);
            string UserResponse = Console.ReadLine();

            while (string.IsNullOrEmpty(UserResponse))

            {
                Console.WriteLine("Nothing was entered, Can you try again?");
                UserResponse = Console.ReadLine();


            }

            while (string.IsNullOrWhiteSpace(UserResponse))
            {
                Console.Write("\r\nPlease do not leave this empty. Try again: ");
                UserResponse = Console.ReadLine();
            }
            return UserResponse;
        }

        //Validate that string is a number
    }
}
