using System;
using System.Collections;
using System.Linq;
using System.Text;

// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Main Method / Initiates Program.   
// Synopsis: Provides a means for the user to select and run any of the other completed coding challenges.
// As we complete each challenge, this will offer a way for the user to run it.

//==================================================================
//CE1 : Menu
//==================================================================

namespace DVP1
{
    public class CE1_Menu
    {
        // Create a Method that will display a welcome message to the user
        public static void WelcomeUser()
        {
            Console.WriteLine("Displayed below is a menu of the code challenges completed throughout the month. \r\nPlease select the number for the challenge you want to run:");
        }

        //Create a New method that will display a menu and prompt the user to make a selection
        public static void MenuChoice()
        {
            //Display the selection choices to the user
            Console.WriteLine("\r\n(1) Swap Name");
            Console.WriteLine("(2) Backwards");
            Console.WriteLine("(3) Age Convert");
            Console.WriteLine("(4) Temp Convert");
            Console.WriteLine("(5) Big Blue Fish");
            Console.WriteLine("(0) EXIT");
            //Prompt the user to make a selection
            Console.WriteLine("\r\nChoose your selection: ");
            string userInput = Console.ReadLine();

            // Make sure the user is entering a valid selection
            bool choice = int.TryParse(userInput, out int selection);
            //Create a while loop to ensure the user is entering a number between 0-5 only
            while (choice == false || selection > 5 || selection < 0)

            {    //Tell the user that they've made a mistake
                Console.WriteLine("You entered an invalid selection. Please enter a number that corresponds to a selection above.");
                //Store the users new input
                userInput = Console.ReadLine();
                //Validate the users new input
                choice = int.TryParse(userInput, out selection);

            }

            // Confirm to the user the selection they entered
            Console.WriteLine("You have entered Challenge #{0}.", selection);

            //Begin switch statement that runs the class challenge the user selected
            switch (selection)
            {

                case 1:
                    Console.WriteLine("The Swap Name Challenge, will now run.\r\n");
                    CE2___SwapName.SwapName();
                    //Display the menu again after the selection runs
                    CE1_Menu.MenuChoice();
                    break;
                case 2:
                    Console.WriteLine("The Backwards Challenge, will now run.\r\n");
                    CE3_Backwards.BackwardsGame();
                    //Display the menu again after the selection runs
                    CE1_Menu.MenuChoice();

                    break;
                case 3:
                    Console.WriteLine("The Age Convert Challenge, will now run.\r\n");
                    CE4_AgeConvert.AgeConvert();
                    //Display the menu again after the selection runs
                    CE1_Menu.MenuChoice();
                    break;
                case 4:
                    Console.WriteLine("The Temp CpnvertChallenge, will now run.\r\n");
                    CE5_TempConvert.TempConvert();
                    //Display the menu again after the selection runs
                    CE1_Menu.MenuChoice();
                    break;
                case 5:
                    Console.WriteLine("The Big Blue Fish Challenge, will now run.\r\n");
                    CE6_BigBlueFish.BigBlueFish();
                    //Display the menu again after the selection runs
                    CE1_Menu.MenuChoice();
                    break;

                case 0:
                    Console.WriteLine("You will now return to the main menu.\r\n");
                    CE1_Menu.MenuChoice();
                    break;

                default:
                    Console.WriteLine("Please enter a valid selection from the above menu.");
                    break;


                    //Outputs based on user selection



            }

        }
    }
}
