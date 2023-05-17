using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            // Testing coffee class
            Coffee myCoffee = new Coffee("Espresso", 75);
            myCoffee.PrintInformation();

            // Testing tea class
            Tea myTea = new Tea("Green Tea", 2.99m, 250);
            myTea.PrintInformation();


            // Testing soup class
            Soup mySoup = new Soup("Tomato Soup", 4.99m, 300);
            mySoup.PrintInformation();

            // Testing fish class
            Fish myFish = new Fish("Salmon", 12.99m);
            myFish.PrintInformation();

            // Testing cake class
            Cake myCake = new Cake("Chocolate Cake");
            myCake.PrintInformation();
        }
    }
}
