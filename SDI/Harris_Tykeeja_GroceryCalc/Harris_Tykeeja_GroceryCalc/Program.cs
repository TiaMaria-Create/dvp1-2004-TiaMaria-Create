using System;

namespace Harris_Tykeeja_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tia Harris
             08/17/19
             Grocery Calculator Assignment
             */

            //----------------------------------------------------------------
            //This program will assist a user with shopping for bananas, beef brisket, and apple pie.
            //The program will ask the user to enter price and quanity values for the shopping items.
            //The program will then calculate the total of all of the items with the sales tax included.

            // Declare the variables that will be used in the shopping list calculator
            //-----------------------------------------------------------------

            //Declare a variable to ask for the price of the shopping list item banana
            string bananaPrice;
            //Declare a variable to ask for the price of the shopping list item beef brisket
            string beefBrisketPrice;
            //Declare a variable to ask for the price of the shopping list item Apple Pie
            string applePiePrice;

            //-----------------------------------------------------------------

            //Introduce the user to the program and ask for their name for a personalized experience.
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Welcome to the Grocery Calculator. What is your name?");
            Console.WriteLine("------------------------------------------------------- \r\n ");
            string userName = Console.ReadLine();
            Console.WriteLine("\r\nHello " + userName + ", This calculator will add items for you. \r\n ");

            //-----------------------------------------------------------------

            //Begin prompts to ask user for price of shopping items

            //Prompt the user for the value of bananaPrice
            Console.WriteLine("What is the price of the banana, " + userName + "? (Enter a number only, such as .79 or 1.)");
            //Define and Store the value of bananaPrice
            bananaPrice = Console.ReadLine();
            //Confirm the price of the banana with the user
            Console.WriteLine("Thanks. You entered $" + bananaPrice + ". The bananas must be on sale. Awesome. \r\n");

            //Prompt the user for the value of beefBrisketPrice
            Console.WriteLine("What is the price of the Beef Brisket, " + userName + "?");
            //Define and Store the value of beefBrisketPrice
            beefBrisketPrice = Console.ReadLine();
            //Confirm the price of the beef brisket with the user
            Console.WriteLine("Thanks. You entered $" + beefBrisketPrice + ". Good Price. But the chicken might be cheaper. \r\n");

            //Prompt the user for the value of applePiePrice
            Console.WriteLine("What is the price of the Apple Pie, " + userName+ "?");
            //Define and store the value of applePiePrice
            applePiePrice = Console.ReadLine();
            //Confirm the price of the Apple Pie
            Console.WriteLine("Thanks. You entered $" +applePiePrice+ ". What a bargain! You can probably splurge on some icecream. \r\n");

            //-----------------------------------------------------------------

            //To add the values for a total, we have to convert and store the prompts into a number data type
            //Each string needs to be converted into a numerical data type so they can work with math operators

            //Convert the string bananaPrice to a number datatype
            //We will use the decimal data type since we want our numbers to add up and balance with the most precision
            decimal bananaPriceConvert = decimal.Parse(bananaPrice);

            //Convert the string beefBrisketPrice to a number datatype
            //We will again use the decimal data type since we are adding numbers dealing with money.
            decimal beefBrisketConvert = decimal.Parse(beefBrisketPrice);

            //Convert the string applePiePrice to a number datatype
            //We will use the decimal datat type
            decimal applePieConvert = decimal.Parse(applePiePrice);

            //-----------------------------------------------------------------

            //To properly add the values from the shopping list, we have to retrieve the quantity from the user
            //Ask the user to define the quantity of the bananas
            Console.WriteLine("How many bananas do you have, " + userName + "? (Use a whole number only.)");
            //Declare and define a varible for banana quantity and ask for the users input
            string bananaQuant = Console.ReadLine();
            //Confirm the amount of bananas the user has
            Console.WriteLine("You entered " + bananaQuant + " for the total amount of bananas you have. \r\n");

            //Ask the user to define the quantity of the beef briskets
            Console.WriteLine("How many Beef Briskets do you have, " + userName + "?");
            //Declare and define a variable for beef brisket quantity and ask for the users input
            string beefBrisketQuant = Console.ReadLine();
            //Confirm the amount of beef brisket the user has
            Console.WriteLine("You entered " + beefBrisketQuant + " for the toal amount of Beef Briskets you have. \r\n");

            //Ask the User to define the quantity of the apple pies
            Console.WriteLine("How many Apple Pies do you have " + userName + "?");
            //Declare and define a variable for apple pie quantity and ask for the users input
            string applePieQuant = Console.ReadLine();
            //Confirm the amount of the apple pie the user has
            Console.WriteLine("You entered " + applePieQuant + " for the total amount of Apple Pies you have. \r\n");

            //-----------------------------------------------------------------

            //To continuing adding the values for a total, we have to convert the quantity variables into a number data type
            //We will assume all of the items are packaged and can not be sold in halfs or thirds, only whole numbers
            //Convert the string bananaQuant to a number data type
            //We will use int data type since we are storing a whole number
            int bananaQuantConv = Convert.ToInt32(bananaQuant);

            //Convert the string beefBrisketConvert to number data type
            //We will use int data type since we are storing a whole number
            int beefBrisketQuanConvert = Convert.ToInt32(beefBrisketQuant);

            //Convert the string applePieQuant to a number data type
            int applePieQuantCon = Convert.ToInt32(applePieQuant);

            //-----------------------------------------------------------------

            //Now ask the user for the sales tax in their area. Ask the user for a whole number
            Console.WriteLine("Thanks " + userName + ". What is the sales tax in your area? (Enter a whole number such as 7 for 7%)");
            //Declare and define a variable for sales tax and ask for the users input
            string salesTax = Console.ReadLine();
            //Confirm the amount of the Sales tax
            Console.WriteLine("The sales tax is " + salesTax+ "% in your area.");

            //-----------------------------------------------------------------

            //Convert the string salextax to a data number type
            Decimal salesTaxConverted = Decimal.Parse(salesTax);

            //-----------------------------------------------------------------

            //Let the user know we are going to add their totals without sales tax
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Now Let's add your totals, " + userName + ".");
            Console.WriteLine("---------------------------------------------");

            //-----------------------------------------------------------------

            //Add the total for the bananas without sales tax.
            //Multiple the price of the bananas by the quantity of the bananas
            //Declare and define a variable to store the total of the bananas without tax
            decimal bananaTotal = bananaPriceConvert *= bananaQuantConv;
            //Print the answer to the console
            Console.WriteLine("The Total amount you will pay for Bananas without taxes is $" +bananaTotal+ ".");

            //Add the total for the beef briskets without sales tax.
            //Multiple the price of the beef briskets by the quantity of the beef briskets
            //Declare and define a variable to store the total of the beef briskets without tax
            decimal beefBrisketTotal = beefBrisketConvert *= beefBrisketQuanConvert;
            //Print the answer to the console
            Console.WriteLine("The Total amount you will pay for Beef Brisket without taxes is $" + beefBrisketTotal + ".");

            //Add the total for the apple pies without sales tax.
            //Multiple the price of the apple pies by the quantity of the apple pies
            //Declare and define a variable to store the total of the beef briskets without tax
            decimal applePieTotal = applePieConvert *= applePieQuantCon;
            //Print the total to the console
            Console.WriteLine("The Total amount you will pay for Apple Pie without taxes is $" + applePieTotal + ".");

            // Add the total of all items without sales tax
            //Declare and define a variable to store the total of all of items without tax
            decimal itemTotal = bananaTotal + beefBrisketTotal + applePieTotal;
            //Print the total to the console
            Console.WriteLine("The total amount of all of your items before taxes is $" + itemTotal + ".");

            //Calculate the total sales tax for all of the items
            //Convert the sales tax input from earlier to a decimal
            Decimal salesTaxTotal = itemTotal * (salesTaxConverted /= 100);
            //Print the sales tax total to the console
            Console.WriteLine("The total amount of taxes for all of your items is $" +salesTaxTotal+ ".");

            //Declare and define a variable to add the total sales tax to the item total
            decimal finalTotal = salesTaxTotal + itemTotal;
            //Print to total to the console
            Console.WriteLine("Your order total including sales tax is $" +finalTotal+ ".");

            //Let the user know we are all done calculating
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Wow " +userName+ ", Your total was $" +finalTotal+ ". It was great shopping with you!");
            Console.WriteLine("---------------------------------------------");


            //---------------------------------------------------------------------------
            // Program has Ended
            //---------------------------------------------------------------------------


            //Test Values

            //Use these values to test that the calculator is functioning

            /* Test #1


            What is the price of the banana?
            bananaPrice = $0.40

            What is the price of the beef brisket
            beefBrisketPrice = $20.25

            What is the price of the apple pie?
            applePiePrice = $9.75

            How many bananas do you have?
            bananaQuant = 4

            How many Beef Briskets do you have?
            beefBrisketQuant = 2

            How many apple pies do you have?
            applePieQuant = 3

            What is the sales tax in your area?
            salesTax = 5

            The Total amount you will pay for Bananas without taxes is $1.60.
            The Total amount you will pay for Beef Brisket without taxes is $40.50.
            The Total amount you will pay for Apple Pie without taxes is $29.25.
            The total amount of all of your items before taxes is $71.35.
            The total amount of taxes for all of your items is $3.5675.
            Your order total including sales tax is $74.9175.


            ---------------------------------------------------------------

            Test #2

            What is the price of the banana?
            bananaPrice = $0.75

            What is the price of the beef brisket
            beefBrisketPrice = $13.24

            What is the price of the apple pie?
            applePiePrice = $3.75

            How many bananas do you have?
            bananaQuant = 6

            How many Beef Briskets do you have?
            beefBrisketQuant = 4

            How many apple pies do you have?
            applePieQuant = 2

            What is the sales tax in your area?
            salesTax = 9

            The Total amount you will pay for Bananas without taxes is $4.50.
            The Total amount you will pay for Beef Brisket without taxes is $52.96.
            The Total amount you will pay for Apple Pie without taxes is $7.50.
            The total amount of all of your items before taxes is $64.96.
            The total amount of taxes for all of your items is $5.8464.
            Your order total including sales tax is $70.8064.



             */


        }
    }
}
