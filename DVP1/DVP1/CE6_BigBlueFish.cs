using System;


// Name: Tykeeja Harris  
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - CE6 Big Blue Fish


namespace DVP1
{
    public class CE6_BigBlueFish
    {
        public static void BigBlueFish()
        {

            //declare and define an array for color
            string[] fishColors = new string[12] { "blue", "green", "purple", "yellow", "blue", "green", "blue", "yellow", "blue", "purple", "yellow", "green", };
            //declare and define an array for length
            float[] fishLength = new float[12] { 2.6F, 18.2F, 6.87F, 9.5F, 10.13F, 5.4F, 15F, 1.4F, 1.7F, 2.3F, 4F, 5.7F, };


            Console.WriteLine("Welcome to BigBlueFish.");
            Console.WriteLine("Looking for the biggest fish matching a certain color?");
            Console.WriteLine(" Please select a color of fish");

            Console.WriteLine("\r\n(1) Blue");
            Console.WriteLine("(2) Green");
            Console.WriteLine("(3) Purple");
            Console.WriteLine("(4) Yellow");

            string userInput = Console.ReadLine();

            //Make sure the user is entering a valid selection(numbers only 1 - 4, no letters)
            bool userChoice = int.TryParse(userInput, out int colorSelection);

            while (userChoice == false || colorSelection > 4 || colorSelection < 1)

            //Prompt the user if they enter an invalid selection to renter

            {
                Console.WriteLine("You entered an invalid selection. Please enter 1, 2, 3 or 4.");
                //Store the users new input
                userInput = Console.ReadLine();
                userChoice = int.TryParse(userInput, out  colorSelection);

            }

            //########################################################

            //Confirm to the user the selection they chose
            Console.WriteLine("You have entered {0},", colorSelection);

      
            Console.WriteLine();
            //To reveal the users selection, we can use a switch or if conditioinal statement
            //Begin a switch statement that reveals the gathered data about the users selection
            switch (colorSelection)
            {
                case 1:
                    Console.WriteLine("Which is the selection for blue fish");
                    Blue(fishLength, fishColors);
                    break;

                case 2:
                    
                    Console.WriteLine("Which is the selection for green fish");
                    Green(fishLength, fishColors);
                    break;

                case 3:
                    Console.WriteLine("Which is the selection for purple fish");
                    Purple(fishLength, fishColors);
                    break;

                case 4:
                    Console.WriteLine("Which is the selection for yellow fish");
                    Yellow(fishLength, fishColors);
                    break;
            }

            //########################################################

            

        }



        public static void Green(float[] firstArray, string[] secondArray)

        {

            float fishLength = 0;

            {
                for (int i = 0; i < secondArray.Length; ++i)
                {
                    if (secondArray[i] == "green")
                    {
                        if (firstArray[i] > fishLength)
                        {
                            fishLength = firstArray[i];
                            //string fishColor = secondArray[i];
                            Console.WriteLine(String.Format("The biggest {0} fish is {1} inches", secondArray[i], fishLength));

                        }
                    }


                }


            }

        }


        public static void Blue(float[] firstArray, string[] secondArray)

        {

            string fishColor = "";
            float fishLength = 0;



           // foreach (var userFish in secondArray)
            {
                for (int j1 = 0; j1 < secondArray.Length; ++j1)
                {
                    if (secondArray[j1] == "blue")
                    {
                        if (firstArray[j1] > fishLength)
                        {
                            fishLength = firstArray[j1];
                            fishColor = secondArray[j1];
                        }
                    }
                }
            }

            Console.WriteLine(String.Format("The biggest {0} fish is {1} inches", fishColor, fishLength));


        }

        public static void Yellow(float[] firstArray, string[] secondArray)

        {

            string fishColor = "";
            float fishLength = 0;

            {
                for (int i = 0; i < secondArray.Length; ++i)
                {
                    if (secondArray[i] == "yellow")
                    {
                        if (firstArray[i] > fishLength)
                        {
                            fishLength = firstArray[i];
                            fishColor = secondArray[i];
                        }
                    }
                }
            }

            Console.WriteLine(String.Format("The biggest {0} fish is {1} inches", fishColor, fishLength));

        }

        public static void Purple(float[] firstArray, string[] secondArray)

        {

            string fishColor = "";
            float fishLength = 0;



            // foreach (var userFish in secondArray)
            {
                for (int j = 0; j < secondArray.Length; ++j)
                {
                    if (secondArray[j] == "purple")
                    {
                        if (firstArray[j] > fishLength)
                        {
                            fishLength = firstArray[j];
                            fishColor = secondArray[j];
                        }
                    }
                }
            }

            Console.WriteLine(String.Format("The biggest {0} fish is {1} inches", fishColor, fishLength)); 

            Console.WriteLine("======================================================");
            Console.WriteLine("Press Enter to go back to the main Menu.");
            Console.ReadKey();


        }

    }


}
