using System;

namespace VendingMachine
{
    internal class SelectionMenuOption
    {
        public double priceSelectedDrink { get; private set; }

        public string Select()
        {
            Console.Write("Please select your Drink :");
            string selectedDrink = Console.ReadLine();

            switch (selectedDrink.ToLower())
            {
                case "coke":
                    priceSelectedDrink = 3.95;
                    break;
                case "fanta":
                    priceSelectedDrink = 4.95;
                    break;
                case "protein":
                    priceSelectedDrink = 5.55;
                    break;
                case "sprite":
                    priceSelectedDrink = 3.95;
                    break;
                default:
                    Console.WriteLine("Selection is not recognised.Please select a drink from the list");
                    break;
            }

            Console.WriteLine("You selected : {0}. Please insert £{1} ", selectedDrink, priceSelectedDrink);
            //return selectedDrink;
            return selectedDrink;
        }
    }
}