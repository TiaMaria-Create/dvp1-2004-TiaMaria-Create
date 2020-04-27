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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0155:Finds issues with format strings", Justification = "<Pending>")]
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

            switch (userOption)
            {

                case 1:
                    //Display to the user their selection
                    Console.WriteLine("Great, you entrered option (1). Convert temperature from Fahrenheit to Celsius.");
                    Console.WriteLine("Ok, what temperature in Fahrenheit would you like to convert?");
                    //Define a variable to store users response
                    string fahTemp = Console.ReadLine();
                    //Make sure the user entered valid data
                    //This will be updated when the validation class is complete
                    bool temp = double.TryParse(fahTemp, out double fahrenheit);

                    //Create a while loop to ensure the user entered selection 1 or 2 only
                    while (choice == false)

                    {    //Tell the user that they've made a mistake
                        Console.WriteLine("We are unable to calculate a temperature from that input. Please enter numerical data only.");
                        //Store the users new input
                        fahTemp = Console.ReadLine();
                        //Validate the users new input
                        temp = double.TryParse(fahTemp, out fahrenheit);
                    }
                    //Confirm what the user entered
                    Console.WriteLine("You entered {0}°F ", fahTemp);
                    //Create a string variable that will push and retrieve the paramenters from the reverse method
                    double fahrenheitToCelsius = FarenheitConversion(fahrenheit);
                    //Print the results to the console to the user
                    Console.WriteLine("Great! {0:F}°F would be {1:F}°C. Awesome!", fahrenheit, fahrenheitToCelsius);
                    break;

                case 2:
                    //Display to the user their selection
                    Console.WriteLine("Great, you entrered option (2). Convert temperature from Celsius to Fahrenheit.");
                    Console.WriteLine("Ok, what temperature in Celsius would you like to convert?");
                    //Define a variable to store users response
                    string celTemp = Console.ReadLine();
                    //Make sure the user entered valid data
                    bool cels = double.TryParse(celTemp, out double celsius);

                    //Create a while loop to ensure the user entered selection 1 or 2 only
                    while (choice == false)

                    {    //Tell the user that they've made a mistake
                        Console.WriteLine("We are unable to calculate a temperature from that input. Please enter numerical data only.");
                        //Store the users new input
                        celTemp = Console.ReadLine();
                        //Validate the users new input
                        cels = double.TryParse(celTemp, out celsius);
                    }

                    //Confirm what the user entered
                    Console.WriteLine("You entered {0}°C", celTemp);
                    double celsiusToFarenheit = CelsiusConversion(celsius);
                    //Calculate the conversion of celsius to fahrenheit
                    //Print to the console the results to the user.
                    Console.WriteLine(String.Format("Great! {0:F}°C would be {1:F}°F. Awesome!", celsius, celsiusToFarenheit));
                    break;
            }

            }

        //Create a method that will convert Farenheit to Celsius
        public static double FarenheitConversion(double fahrenheit)

        {
            double fahrenheitToCelsius = (fahrenheit - 32) * 5 / 9;
            return fahrenheitToCelsius;
        }

        //Create a method that will convert Celsius to Farenheit
        public static double CelsiusConversion(double celsius)

        {
            double celsiusToFahrenheitConversion = (celsius * 9) / 5 + 32;
            return celsiusToFahrenheitConversion;
        }
    }
}


//Test Equations
// double fahrenheitToCelsius = (fahrenheit - 32) *5 / 9;
//double celsiusToFahrenheitConversion = (celsius * 9) / 5 + 32;
