using System;

namespace Harris_Tykeeja_CustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tykeeja Harris
             * Mar 5th 2020
             * Custom Class Assignment
             */

            //==================================================================
            //Problem : Inventory System
            //==================================================================

            //This project will create a custom a class that will hold information about products for an
            //inventory in an online store.

            //Instantiate three products that will use the custom class

            //First Product
            Product chickenAndAsparagus = new Product("Garlic Roasted Chicken, White Cheddar Mashed Potatoes & Asaparagus", 15.20m, 30.30m);
            //Second Prodct
            Product truffleMac = new Product("Vermont Cheddar, Mushroom, & Truffle Mac and Cheese", 25.33m, 40.00m);
            //Third Product
            Product veganburger = new Product("Mixed Bean and Mushroom Burger w/ Black Garlic Aioli", 22.46m, 33.00m);

            //Present a Menu to the user that will display the items for sale
            Console.WriteLine("Welcome to The Shark Bistro & Bar, please take a look at our daily specials. For every daily special purchased, The Shark Bistro and Bar will donate the profit from the sale to Feed the Homeless. When you buy a meal you give a meal.");
            Console.WriteLine("\r\nSpecial #1: " + chickenAndAsparagus.GetName());
            Console.WriteLine("Special #2: " + truffleMac.GetName());
            Console.WriteLine("Special #3: " + veganburger.GetName());

            //Ask the user what menu item they would like
            Console.WriteLine("\r\nWhich daily special would you like to order? 1 ,2 or 3?");
            string userInput = Console.ReadLine();

            //Declare a number data type where we can store the users input

            // Make sure the user is entering a valid selection (numbers only 1-3, no letters)
            bool userChoice = int.TryParse(userInput, out int menuSelection);

            while (userChoice == false || menuSelection > 3 || menuSelection < 1)

                //Prompt the user if they enter an invalid selection to renter

            {
                Console.WriteLine("You entered an invalid selection for our daily special. Please enter 1, 2 or 3.");
                //Store the users new input
                userInput = Console.ReadLine();
                userChoice = int.TryParse(userInput, out menuSelection);

            }

            //Confirm to the user the selection they chose
            Console.WriteLine("You have entered Special #{0}.", menuSelection);

            //Begin conditional statement that reveals the class information about the users selection
            if (menuSelection == 1)
            {
                Console.WriteLine("Your selection is the {0}. The price is ${1}. It costs ${2} to create this meal.", chickenAndAsparagus.GetName(), chickenAndAsparagus.GetItemPrice(), chickenAndAsparagus.GetCost());
                Console.WriteLine("The total amount of your donation will be ${0}", chickenAndAsparagus.Profit(1));
            }

            else if (menuSelection == 2)
            {
                Console.WriteLine("Your selection is the {0}. The price is ${1}. It costs ${2} to create this meal.", truffleMac.GetName(), truffleMac.GetItemPrice(), truffleMac.GetCost());
                Console.WriteLine("The total amount of your donation will be ${0}", truffleMac.Profit(1));
            }

            else if (menuSelection == 3)
            {
                Console.WriteLine("Your selection is the {0}. The price is ${1}. It costs ${2} to create this meal.", veganburger.GetName(), veganburger.GetItemPrice(), veganburger.GetCost());
                Console.WriteLine("The total amount of your donation will be ${0}", veganburger.Profit(1));
            }

            //Ask the user for the quantity of the product the want to purchase
            Console.WriteLine("How many meals will you be purchasing?");
            string userQuantity = Console.ReadLine();

            //Declare a data type to store the users input for quantity

            // Make sure the user is entering a valid selection
            bool quantity = int.TryParse(userQuantity, out int quant);

            while (quantity == false)

            {
                Console.WriteLine("You entered an invalid amount. Please enter a number");
                userQuantity = Console.ReadLine();
                quantity = int.TryParse(userQuantity, out quant);

            }

            //Determine the total profit for the item

           /* if (menuSelection == 1)
            {
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, chickenAndAsparagus.GetName(), chickenAndAsparagus.Profit(quant));

            }
            else if (menuSelection == 2)
            {
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, truffleMac.GetName(), truffleMac.Profit(quant));

            }

            else if (menuSelection == 3)
            {
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, veganburger.GetName(), veganburger.Profit(quant));

            }*/


            switch (menuSelection)
            {

                case 1:
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, chickenAndAsparagus.GetName(), chickenAndAsparagus.Profit(quant));
                break;
                case 2:
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, truffleMac.GetName(), truffleMac.Profit(quant));
                break;
                case 3:
                Console.WriteLine("If you purchased {0} {1} specials, you would donate ${2} to the charity. Thats Great!", quant, veganburger.GetName(), veganburger.Profit(quant));
                break;
                        //Outputs based on user selection

            }


        }
    }
}
