using System;
using System.Collections.Generic;

namespace Harris_Tykeeja_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 9/17/19
             * Function Problems
             * Section #01
             * Tykeeja Harris
             * */

            //Being Problem #1
            //****************
            //Problem #1: Currency Converter
            //*****************
            Console.WriteLine("Problem #1: Currency Converter. \r\n************");
            //We will create a program that will convert Euros to American dollars
            //Currently Google confirms that 1 Euro is equal to $1.10 in American Dollars.
            //For this assignment we are given the value that 1 euro is equal to $1.16 in American Dollars


            //First Tell the User what we are doing and ask them for the amount they have in Euros
            Console.WriteLine("Hello! This program will help you convert your Euros to American Dollars. How many Euros do you have?");

            //Catch the users repsonse and store it in a string variable to be converted later
            string euroString = Console.ReadLine();

            //declare a variable to hold the converted value for Euro
            //We will declare a decimal since we are dealing with money
            decimal euro;

            //Convert the string to a decimal and validate the user is inputting numerical values
            while (!decimal.TryParse(euroString, out euro))
            {
                //alert the user to the error
                Console.WriteLine("Please only type in numbers and do not leave blank. \r\nHow many Euros do you have?");

                //recapture users response
                euroString = Console.ReadLine();

            }

            //Confirm the amount of euros back to the user
            Console.WriteLine("Thank you! you entered that you have {0} euros.", euro);

            //Now we will create a method outside of the main method to calculator the conversion of euros to american dollars
            //After creating the method will will convert the users input for euro to dollars
            //We now have to call the function thayt we creted for the conversion
            decimal conversion = ConvertEuro(euro);

            //Round the conversion to two decimal places
            //  conversion = Math.Round(Decimal, Int32);

            //Report the results of the conversion to the user by printing it to the console
            Console.WriteLine("Your amount of {0} euros converts to ${1} American Dollars.", euro, Math.Round(conversion, 2, MidpointRounding.ToEven));

            /* Test Values

            Test 1
            Hello! This program will help you convert your Euros to American Dollars. How many Euros do you have?
            5.50
            Thank you! you entered that you have 5.50 euros.
            Your amount of 5.50 euros converts to $6.38 American Dollars.

            Test 2
            Hello! This program will help you convert your Euros to American Dollars. How many Euros do you have?
            15.32
            Thank you! you entered that you have 15.32 euros.
            Your amount of 15.32 euros converts to $17.77 American Dollars.

            Test 3
            Hello! This program will help you convert your Euros to American Dollars. How many Euros do you have?
            cat
            Please only type in numbers and do not leave blank. 
            How many Euros do you have?
            dog
            Please only type in numbers and do not leave blank. 
            How many Euros do you have?
            100
            Thank you! you entered that you have 100 euros.
            Your amount of 100 euros converts to $116.00 American Dollars.
                */

            //Being Problem #2
            //****************
            //Problem #2: Astronomical
            //*****************
            Console.WriteLine("************* \r\nProblem #2: Astronomical. \r\n************");
            //We will create a program that with convert the users weight on earth to their weight on another planet.
            //First wee will ask their user what is their weight on earth

            Console.WriteLine(" Hello, What is your current weight?");
            //Create a variable to store the users weight
            string earthWeightString = Console.ReadLine();

            //declare a variable to hold to converted value of users weight
            double earthWeight;

            //Convert the string to a double and validate the user is inputting numerical values
            while (!double.TryParse(earthWeightString, out earthWeight))
            {
                //alert the user to the error
                Console.WriteLine("Please only type in numbers and do not leave blank. \r\nHow much do you weigh currently?");

                //recapture users response
                earthWeightString = Console.ReadLine();

            }


            //Confirm to the user the weight they entered
            Console.WriteLine("Thanks. You entered that you currently weigh {0} lbs on earth.", earthWeight);

            //Create the list of planets
            List<string> planetList = new List<string>() { "planets" };
            planetList.Insert(1, "1. Mercury");
            planetList.Insert(2, "2. Venus");
            planetList.Insert(3, "3. Earth");
            planetList.Insert(4, "4. Mars");
            planetList.Insert(5, "5. Jupiter");
            planetList.Insert(6, "6. Saturn");
            planetList.Insert(7, "7. Uranus");
            planetList.Insert(8, "8. Neptune");



            //Ask the user to choose a planet
            Console.WriteLine("Please Select which planet you would like to check your weight on.");

            //For loop to cycle through the list of planets
            for (int i = 1; i < planetList.Count; i++)

            {
                //Display the list of planets to the user
                Console.WriteLine("{0}", planetList[i]);


            }

            //Create a variable to store the users response
            string UsersInputString = Console.ReadLine();

            //Create a variable for the userinput to convert the value for the input to an int
            double userInput;

            //Convert the string to a int and validate the user is inputting correct values
            while (!double.TryParse(UsersInputString, out userInput) || (userInput <=0 || userInput > 8))
            {
                //alert the user to the error
                Console.WriteLine("Please only type in a valid selection 1-8 and do not leave blank. \r\n Select a planet.");

                //recapture users response
                UsersInputString = Console.ReadLine();

            }

            //Begin our conditional statement
            if (UsersInputString == "1")
            {
                UsersInputString = planetList[1];
                double percent = 0.38;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "2")
            {
                UsersInputString = planetList[2];
                double percent = 0.91;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "3")
            {
                UsersInputString = planetList[3];
                double percent = 0.100;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "4")
            {
                UsersInputString = planetList[4];
                double percent = 0.38;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "5")
            {
                UsersInputString = planetList[5];
                double percent = 2.34;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "6")
            {
                UsersInputString = planetList[6];
                double percent = 0.93;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "7")
            {
                UsersInputString = planetList[7];
                double percent = 0.92;
                //function call
                double results = planetChoice(earthWeight, percent);

                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);
            }

            else if (UsersInputString == "8")
            {
                UsersInputString = planetList[8];
                double percent = 1.12;
                //function call
                double results = planetChoice(earthWeight, percent);


                //Print to the Console the users weight
                Console.WriteLine("On earth you weigh {0}lbs, but on {1} you would weigh {2} lbs.", earthWeight, UsersInputString, results);

             

            }
        }


        //Create New Methods


        //Problem One
        //Create a New method to do the math for the conversion in Problem #1

        public static decimal ConvertEuro(decimal eur)
        {
            //create a variable for the conversion
            decimal conversion = eur * 1.16m;
            return conversion;
        }



        //Problem Two
        //Create a new method to do the math for Problem 2
        public static double planetChoice(double weight, double percent)

        {
            //create a variable for the math for converting astronaut weight on different planets
            double planetWeight = weight * percent;
            return planetWeight;
        }
    }

}
