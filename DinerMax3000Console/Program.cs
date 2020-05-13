using System;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Lake Superior Salmon with an uncomfortable amount of Mayonnaise", 25.50);
            summerMenu.AddMenuItem("Tacos", "Isnt everyday taco tuesday", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr. Howser";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Whiskey Sour", "The best of all the classics", 10);
            outsideDrinks.AddMenuItem("Vesper Martini", "Shaken, not stirred", 15);


            Order hungryGuestOrder = new Order();

            for(int x=0; x<=summerMenu.items.Count-1; x++) 
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total is:" + hungryGuestOrder.Total);
            Console.ReadKey();

        }
    }
}