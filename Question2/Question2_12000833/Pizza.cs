using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question2_12000833
{
    class Pizza
    {
        //Mogamat Tariq Patel 12000833 PROG6211 assignment1 question2
        //initializing instance variables
        private string typeOfPizza;
        private int numbOfPizzasOrdered;
        private double pricePerPizza;

        // Constructor for the pizza class
        public Pizza(string aTypeOfPizza,int aNumbOfPizzasOrdered,double aPricePerPizza)
        {
            typeOfPizza = aTypeOfPizza;
            numbOfPizzasOrdered = aNumbOfPizzasOrdered;
            pricePerPizza = aPricePerPizza;
        }

        //Method to calculate the order total
        public double CalculateTotal()
        {
            double orderTotal = pricePerPizza * numbOfPizzasOrdered;
            return orderTotal;

        }

        //Method to display pizza order
        public string DisplayPizzaOrder()
        {

            string order = "YOUR PIZZA ORDER\n================\nType of Pizza:\t\t" + typeOfPizza + "\nNumber of Pizzas:\t" + numbOfPizzasOrdered + 
                "\nPrice per Pizza:\tR " + pricePerPizza + "\nOrder Total:\t\tR " + CalculateTotal();
            
            return order;
        }
    }
}
