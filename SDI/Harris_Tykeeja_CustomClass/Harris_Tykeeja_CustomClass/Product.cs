using System;
namespace Harris_Tykeeja_CustomClass
{
    public class Product
    {
        //Create three member variables and a constructor function to build the object

        //Create Three Member Variables
        string mName;
        decimal mcost;
        decimal mitemPrice;

        //Create the constructor function
        public Product (string _name, decimal _cost, decimal _itemPrice)

        {
            //Use the parameters to initialize the original member variables
            mName = _name;
            mcost = _cost;
            mitemPrice = _itemPrice;

        }

        //Create Getters that will allow the class information to be accessed and return it back to where it was called

        //Create a getter function for the product name
        public string GetName()

        {
            //return the value of the products name to where it was called
            return mName;
        }


        //Create a getter function for the product cost
        public decimal GetCost()

        {
            //return the value of the products manufacturing costs to where it was called
            return mcost;
        }


        //Create a getter function for the products selling price
        public decimal GetItemPrice ()

        {
            //return the value of the producst selling price back to where it was called
            return mitemPrice;
        }


        //Create Setters the allow the member variables of the class to be accessed and changed

        //Create a setter function for the product name
        public void SetName (string _name)
        {
            //Change the member variable for name and use the parameter
            mName = _name;
        }


        //Create a setter function for the product manufacturing cost
        public void SetCost (decimal _cost)
        {
            //Change the member variable for name and use the parameter
            mcost = _cost;
        }

        //Create a setter function for the product selling price
        public void SetPrice (decimal _itemPrice)
        {
            //Change the member variable for name and use the parameter
            mitemPrice = _itemPrice;
        }

        //Create a custom method that calculates the total profit of the product
        //Profit is the different between the manufacturing cost and the item price
        public decimal Profit(decimal _itemQuant)
        {
            decimal profit = (mitemPrice - mcost ) * _itemQuant;
            return profit;
        }
    }
}
