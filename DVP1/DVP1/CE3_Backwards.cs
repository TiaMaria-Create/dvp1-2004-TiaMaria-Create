using System;


// Name: Tykeeja Harris
// Date: 2020 April
// Course: Project & Portfolio 1 
// CE Name: Coding Exercise - Reverse Name

namespace DVP1
{
    public class CE3_Backwards
    {
        // Remember Public, Static methods are available to the entire solution.
        public static void BackwardsGame()
        {


            Console.WriteLine("Enter a Sentence at least 6 words in length.");
            //Getting String(word) from Console  
            string userSentence = Console.ReadLine();

            //define a variable to be used to count the number of words the use enters
            int wordCount = 0;

            //Count the words the user has entered
            for (int i = 0; i < userSentence.Length ; i++)

            {
                //Counts all the spaces present in the string  and does not include first space
                //researched IsLetter using stackoverflow 
                if (userSentence[i] == ' ' && Char.IsLetter(userSentence[i + 1]) && (i > 0))
                {
                    wordCount++;
                }

            }

            Console.WriteLine("Your total is {0}", wordCount++);

            //Verify the user has entered valid input
            while (string.IsNullOrWhiteSpace(userSentence) || (wordCount < 6))

            {
                //Tell the user what is wrong
                Console.WriteLine("\r\nPlease enter at least six words.");
                //Catch the response again
                userSentence = Console.ReadLine();

                //Count the words the user has entered
                for (int i = 0; i < userSentence.Length - 1; i++)

                {
                    //Counts all the spaces present in the string  and does not include first space
                    //researched IsLetter using stackoverflow 
                    if (userSentence[i] == ' ' && Char.IsLetter(userSentence[i + 1]) && (i > 0))
                    {
                        wordCount++;
                    }
                }


            }

            //count the last word in the string, by adding 1  
            wordCount++;

            Console.WriteLine("You entered " + userSentence + ", Thanks!");


            string reverse = "";
            int Length = 0;

            //Calculate length of string str  
            Length = userSentence.Length - 1;

            while (Length >= 0)

            {
                reverse = reverse + userSentence[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("\r\nReversed your sentence is: \r\n{0}", reverse);


            Console.WriteLine("======================================================");
            Console.WriteLine("Press Enter to go back to the main Menu.");
            Console.ReadKey();
        }


 

    }



}