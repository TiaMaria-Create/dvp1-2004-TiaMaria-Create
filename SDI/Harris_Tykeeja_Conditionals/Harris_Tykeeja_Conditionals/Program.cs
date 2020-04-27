using System;

namespace Harris_Tykeeja_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             Tykeeja Harris
             SDI Conditionals
             Section 01
             September 12th 2019

             */

            //Conditionals and Logical Operators Project
            //==================================================================
            //Sample Problem
            //Stuff Your Face
            /* To	get	in	the	heavyweight	division	of	the	Strawberry	Festival’s	pie	eating	contest	you	must weigh	250	lbs.
            or	more. Determine	whether	an	entrant	qualifies	based	on	his	weight. */

            //Define a variable for a users weight

            //Ask the user for his weight
            Console.WriteLine("How much do you weigh?");
            //Declare and define a variable to store the users weight
            string inputWeight = Console.ReadLine();

            //Convert the users answer into a data type we can use in our conditional statement
            int competitorsWeight = int.Parse(inputWeight);
            //Check if the conversion works
            Console.WriteLine("You entered that you weigh " + competitorsWeight + "lbs.");

            //Begin the conditional statement
            //If the competitor is 250lbs or more he qualifies for the heavyweight divison

            if (competitorsWeight >= 250)
            {
                Console.WriteLine("Congratulations! You qualify for the heavyweight division.");
            }
            else
            {
                Console.WriteLine("Sorry but you do not meet the weight requirments. You need to gain some weight to be in this division.");
            }

            //==================================================================
            //Problem #1: Free Shipping
            Console.WriteLine("==========================");
            Console.WriteLine("Problem #1: Free Shipping.");
            Console.WriteLine("==========================");

            //An online store gives free shipping to users that buy 5 or more items.
            //If they have less than 4 items they will have to pay $1.25 per item for shipping.

            //Ask the user for the number of items they are buying
            Console.WriteLine("How many items are in your cart?");
            //Store the users input in a variable to be used later
            string userCart = Console.ReadLine();

            //Declare a number data type we can use
            //We will use decimal, as we will be multiplying by a decimal later on.
            decimal cartItems;

            // Make sure the user is entering valid input
            bool userInput = decimal.TryParse(userCart, out cartItems);

            while (userInput == false)

            {
                Console.WriteLine("You entered an invalid response. Please enter a number for the quantity of items.");
                userCart = Console.ReadLine();
                userInput = decimal.TryParse(userCart, out cartItems);
            }

            //Confirm to the user the number of items they entered
            Console.WriteLine("You have entered a total of " + cartItems + " items. Press enter to continue.");
            //Allow the user to press enter to continue
            Console.ReadLine();

            //If the user has less than five items in their cart, give them their shipping total.
            //Multiple the user input by 1.25 for the total shipping amount, store in a variable to be used later in a conditional.
            decimal shippingTotal = (cartItems * 1.25m);
            //Test that this mutiplication works
            Console.WriteLine("Standard shipping for " + cartItems + " items is $" + shippingTotal);



            //Begin Conditional Statement
            if (cartItems < 5)
            {
                Console.WriteLine("Your total cost for shipping today for " + cartItems + " items is $" + shippingTotal);
            }

            else

            {
                Console.WriteLine("Congratulations, you have bought " + cartItems + " items, so you qualify for free shipping.");
            }

            //This will allow me to press enter when I am ready to view the next problem.
            Console.ReadLine();

            //Test Data
            /*
            How many items are in your cart?
            2
            You have entered a total of 2 items. Press enter to continue.

            Standard shipping for 2 items is $2.50
            Your cost for shipping today for 2 items is $2.50


            How many items are in your cart?
            4
            You have entered a total of 4 items. Press enter to continue.

            Standard shipping for 4 items is $5.00
            Your cost for shipping today for 4 items is $5.00

            

            How many items are in your cart?
            5
            You have entered a total of 5 items. Press enter to continue.

            Standard shipping for 5 items is $6.25
            Congratulations, you have bought 5 items, so you qualify for free shipping.



            How many items are in your cart?
            7
            You have entered a total of 7 items. Press enter to continue.

            Standard shipping for 7 items is $8.75
            Congratulations, you have bought 7 items, so you qualify for free shipping.



            How many items are in your cart?
            12
            You have entered a total of 12 items. Press enter to continue.

            Standard shipping for 12 items is $15.00
            Congratulations, you have bought 12 items, so you qualify for free shipping.
            */

            //==================================================================
            //Problem #2: Mall Employee Discount
            Console.WriteLine("==========================");
            Console.WriteLine("Problem #2: Mall Employee Discount.");
            Console.WriteLine("==========================");

            //If the customer is a mall employee he will receive a 10% discount
            //The customer purchases two items



            //Prompt the customer for the cost of his items
            Console.WriteLine("Hello, what is the cost of your first item?");
            //Declare a varible and store the users response
            string item1 = Console.ReadLine();
            //Confirm the amount the user entered.
            Console.WriteLine("You entered $" + item1);
            
            // Make sure the user is entering valid input
            bool itemNum = decimal.TryParse(item1, out decimal item1Cost);

            while (itemNum == false)

            {
                Console.WriteLine("You entered an invalid response. Please enter a number for the cost of item.");
                item1 = Console.ReadLine();
                itemNum = decimal.TryParse(item1, out  item1Cost);
            }

            //Prompt the user for the cost of the second item
            Console.WriteLine("Thank you. What is the cost of your second item?");
            //Declare a variable and store the users repsonse
            string item2 = Console.ReadLine();


            // Make sure the user is entering valid input
            bool itemNum2 = decimal.TryParse(item2, out decimal item2Cost);

            while (itemNum2 == false)

            {
                Console.WriteLine("You entered an invalid response. Please enter a number for the cost of item.");
                item2 = Console.ReadLine();
                itemNum2 = decimal.TryParse(item2, out item2Cost);
            }


            //Confirm the amount the user entered.
            Console.WriteLine("Thank you. You entered $" + item2);

            //Ask the user if they are an employee
            Console.WriteLine(" Are you a current Mall employee? YES/NO?");
            //Store the users input in a variable to be used for later
            string employee = Console.ReadLine();
            //Convert user input to uppercase
            employee = employee.ToUpper();

            //Add the item costs
            decimal totalPurchase = item1Cost + item2Cost;
            //Calculate the employee discount
            decimal employeeDiscount = totalPurchase * 0.10m;
            //Finish the math to calculate the percentage off
            decimal afterDiscount = totalPurchase - employeeDiscount;

            //Begin Conditional Statement
            //If the user is an employee they will pay a discounted price
            if (employee == "YES")
            {
                Console.WriteLine("Your total purchase is $" + totalPurchase + ". With your employee discount your total is $" + afterDiscount);
            }
            else
            {
                //If the user is not an employee they will pay full price
                Console.WriteLine("Your total purchase is $" + totalPurchase);
            }

            //This will allow me to press enter when I am ready to view the next problem.
            Console.ReadLine();

            //Test Data
            /*
             
            ==========================
            Problem #2: Mall Employee Discount.
            ==========================
            Hello, what is the cost of your first item?
            65.90
            You entered $65.90
            Thank you. What is the cost of your second item?
            85.00
            Thank you. You entered $85.00
                Are you a current Mall employee? YES/NO?
            yes
            Your total purchase is $150.90. With your employee discount your total is $135.8100


            Hello, what is the cost of your first item?
            19.99
            You entered $19.99
            Thank you. What is the cost of your second item?
            40.20
            Thank you. You entered $40.20
             Are you a current Mall employee? YES/NO?
            no

            ==========================
            Problem #2: Mall Employee Discount.
            ==========================
            Hello, what is the cost of your first item?
            16.42
            You entered $16.42
            Thank you. What is the cost of your second item?
            99.78
            Thank you. You entered $99.78
             Are you a current Mall employee? YES/NO?
            yes
            Your total purchase is $116.20. With your employee discount your total is $104.5800

             */
            //==================================================================
            //Problem #3: Apple Pickers
            Console.WriteLine("==========================");
            Console.WriteLine("Problem #3: Apple Pickers.");
            Console.WriteLine("==========================");

            //Determine the cost of apples by how much they weigh
            //Ask the user for the weight of the apple
            Console.WriteLine("Hello! What is the weight of the apples in your basket?");
            //Declare a a variable to store the users response for later use
            string appleLbs = Console.ReadLine();
            //declare variable for a number data type for later use
            decimal appleWeight;

            // Make sure the user is entering valid input
            bool isNum = decimal.TryParse(appleLbs, out appleWeight);

            while (isNum == false)

            {
                Console.WriteLine("Please enter an appropriate weight value, such as 12.2");
                appleLbs = Console.ReadLine();
                isNum = decimal.TryParse(appleLbs, out appleWeight);
            }

            //Confirm the weight of the apples back to the user.
            Console.WriteLine("You entered that your apples weigh " + appleWeight + " lbs.");

            //Begin our conditional statement
            if (appleWeight < 7)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 1.00m) + " for your apples.");
            }
            else if (appleWeight < 15.25m)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 0.90m) + " for your apples.");

            }
            else if (appleWeight < 40)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 0.80m) + " for your apples.");
            }
            else if (appleWeight < 70.5m)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 0.70m) + " for your apples.");
            }
            else if (appleWeight <= 100)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 0.60m) + " for your apples.");
            }
            else if (appleWeight > 100)
            {
                Console.WriteLine("You will pay $" + (appleWeight * 0.50m) + " for your apples.");
            }

            //This will allow me to press enter when I am ready to view the next problem.
            Console.ReadLine();

            //Test Data
            /*

            Hello! What is the weight of the apples in your basket?
            4.5
            You entered that your apples weigh 4.5 lbs.
            You will pay $4.500 for your apples.

            Hello! What is the weight of the apples in your basket?
            10
            You entered that your apples weigh 10 lbs.
            You will pay $9.00 for your apples.

            Hello! What is the weight of the apples in your basket?
            15.25
            You entered that your apples weigh 15.25 lbs.
            You will pay $12.2000 for your apples.

            Hello! What is the weight of the apples in your basket?
            30
            You entered that your apples weigh 30 lbs.
            You will pay $24.00 for your apples.

            Hello! What is the weight of the apples in your basket?
            60.50
            You entered that your apples weigh 60.50 lbs.
            You will pay $42.3500 for your apples.

            Hello! What is the weight of the apples in your basket?
            100
            You entered that your apples weigh 100 lbs.
            You will pay $60.00 for your apples.

            Hello! What is the weight of the apples in your basket?
            150.30
            You entered that your apples weigh 150.30 lbs.
            You will pay $75.1500 for your apples.

            Hello! What is the weight of the apples in your basket?
            7 
            You entered that your apples weigh 7 lbs.
            You will pay $6.30 for your apples.
             */

            //==================================================================
            //Problem #4: Nerd Out
            Console.WriteLine("\r\n==========================");
            Console.WriteLine("Problem #4: Nerd Out.");
            Console.WriteLine("==========================");

            
            //Ask the user for their age
            Console.WriteLine("Hello, how old are you on todays date?");
            //Store the users response in a variable
            string ageAsk = Console.ReadLine();
            //Declare a variable for a number data type for later use
            int age;


            // Make sure the user is entering valid input
            bool ageNum = int.TryParse(ageAsk, out age);

            while (ageNum == false)

            {
                Console.WriteLine("You entered an invalid response. Please enter your age.");
                ageAsk = Console.ReadLine();
                ageNum = int.TryParse(ageAsk, out age);
            }

            //Confirm the age back to the user.
            Console.WriteLine("You entered that your age is " + age+ " years old.");

            //Begin conditional statement using a single block of code
            if (age >= 65 || age < 7)
            {
                Console.WriteLine("Your ticket price for Comic Con is $40.00");
            }else
            {
                Console.WriteLine("Your ticket price for Comic Con is $55.00");
            }

            //Test Data
            /*

            Hello, how old are you on todays date?
            68
            You entered that your age 68 years old.
            Your ticket price for Comic Con is $40.00

            Hello, how old are you on todays date?
            29
            You entered that your age 29 years old.
            Your ticket price for Comic Con is $55.00

            Hello, how old are you on todays date?
            6
            You entered that your age 6 years old.
            Your ticket price for Comic Con is $40.00

            Hello, how old are you on todays date?
            7
            You entered that your age 7 years old.
            Your ticket price for Comic Con is $55.00

            Hello, how old are you on todays date?
            176
            You entered that your age 176 years old.
            Your ticket price for Comic Con is $40.00


             */
        }
    }
}
