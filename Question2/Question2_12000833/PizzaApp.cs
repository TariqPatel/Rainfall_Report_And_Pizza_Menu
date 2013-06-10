using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question2_12000833
{
    class PizzaApp
    {
        static void Main(string[] args)
        {
            //Mogamat Tariq Patel
            //initilising main variables and arrays
            string pizzaTypes;
            int pizzaNumbs;
            string pizzaNames;
            double pizzaPrices;
            string[] pizzaType =PizzaType();
            string[] pizzaName = PizzaName();
            double[]  pizzaPrice =PizzaPrice();
            
            //calling methods
            DisplayMenu(pizzaType,pizzaName,pizzaPrice);
            pizzaTypes = getPizzaType();
            pizzaNumbs =getPizzaNumber();
            Console.Clear();
            pizzaNames =getPizzaName(pizzaTypes,pizzaType,pizzaName);
            pizzaPrices =getPizzaPrice(pizzaTypes, pizzaType, pizzaPrice);

            //instantiating pizza object
            Pizza pizza1 = new Pizza(pizzaNames,pizzaNumbs,pizzaPrices);

            Console.WriteLine(pizza1.DisplayPizzaOrder());
        }


        // displaying the menu
        static void DisplayMenu(string[] pizzaType,string[] pizzaName,double[] pizzaPrice)
        {
            Console.WriteLine("MENU\n====");
            
            //loop for displaying the menu
            for (int i = 0; i < pizzaType.Length;i++ )
            {

                Console.WriteLine("{0})\t{1}\t{2:C}",pizzaType[i],pizzaName[i],pizzaPrice[i]);
            }
            
            Console.WriteLine("");
            
      }
        // getting the pizza type
        static string getPizzaType()
        {

            Console.Write("Which type of pizza would you like to order (M , H or C)? ");
            string pizzaType = Console.ReadLine();
            string upperPizzaType = pizzaType.ToUpper();
            return upperPizzaType;
        }
        //getting the number of pizzas orderd
        static int getPizzaNumber()
        {

            Console.Write("How many pizzas would you like to order? ");
            int numbPizzas =int.Parse(Console.ReadLine());

            return numbPizzas;
        }
        //getting the pizzas name
        static string getPizzaName(string pizzaType,string[] pizzaTypes, string[] pizzaName)
        {
            string pizzaNames ="";
            for (int i = 0; i < pizzaTypes.Length;i++ )
            {
                if (pizzaTypes[i] == pizzaType)
                {
                    pizzaNames = pizzaName[i];
                }
            }
            return pizzaNames;
        }

        //getting the pizza price
        static double getPizzaPrice(string pizzaType, string[] pizzaTypes, double[] pizzaPrice)
        {
            double pizzaPrices = 0;
            for (int i = 0; i < pizzaTypes.Length; i++)
            {
                if (pizzaTypes[i] == pizzaType)
                {
                    pizzaPrices = pizzaPrice[i];
                }
            }
            return pizzaPrices;
        }
        // initalizing the pizza type array
        static string[] PizzaType()
        {
            string[] pizzaType = new string[3];
            pizzaType[0] = "M";
            pizzaType[1] = "H";
            pizzaType[2] = "C";
            return pizzaType;
 }
        // initializing the pizza name array
        static string[] PizzaName()
        {

            string[] pizzaName = new string[3];
            pizzaName[0] = "Margerita";
            pizzaName[1] = "Hawaiian";
            pizzaName[2] = "Chicken & Avo";
            return pizzaName;

        }
        // initializing the pizza price array
        static double[] PizzaPrice()
        {
            double[] pizzaPrice = new double[3];
            pizzaPrice[0] = 28.99;
            pizzaPrice[1] = 31.99;
            pizzaPrice[2] = 35.99;
            return pizzaPrice;

        }

    }
}
