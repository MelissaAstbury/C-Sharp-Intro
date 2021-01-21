﻿using System.Collections.Generic;
using System.Threading;

// Welcome to pizza builder

// your task is to write the Build method so that cheese, sauce and both toppings are prepped.
// once they're prepped, they should each be added to the pizza dictionary as key/value pairs then return the dictionary
// e.g. Cheese/cheddar, ToppingOne/olives
// there is already a unit test in place that shouldn't be modified - you're working to a tight deadline!

namespace Threading
{
    public class PizzaBuilder
    {
        private string Sauce { get; set; }

        private string Cheese { get; set; }

        private string ToppingOne { get; set; }

        private string ToppingTwo { get; set; }

        // do not modify code above this line

        public Dictionary<string, string> Build()
        {
            var pizza =  new Dictionary<string, string>();

            // add sauce to Pizza by making it's own thread
            var sauceThread = new Thread(PrepSauce);
            sauceThread.Start();

            var cheeseThread = new Thread(PrepCheese);
            cheeseThread.Start();

            var toppingOne = new Thread(PrepVeg);
            toppingOne.Start();

            var toppingTwo = new Thread(PrepHam);
            toppingTwo.Start();

            // join back into the main thread
            sauceThread.Join();
            cheeseThread.Join();
            toppingOne.Join();
            toppingTwo.Join();

            // add to pizza dictionary
            pizza["Sauce"] = Sauce;
            pizza["Cheese"] = Cheese;
            pizza["ToppingOne"] = ToppingOne;
            pizza["ToppingTwo"] = ToppingTwo;
            
            return pizza;
        }

        // do not modify code below this line

        private void PrepCheese()
        {
            Thread.Sleep(1200);

            if (Sauce == null) return;

            Cheese = "Babybell";
        }

        private void PrepVeg()
        {
            Thread.Sleep(1800);

            if (Cheese == null) return;

            ToppingOne = "A potato";
        }

        private void PrepSauce()
        {
            Thread.Sleep(1000);

            Sauce = "Ketchup";
        }

        private void PrepHam()
        {
            Thread.Sleep(1900);

            if (ToppingOne == null) return;

            ToppingTwo = "Prosciutto";
        }
    }
}
