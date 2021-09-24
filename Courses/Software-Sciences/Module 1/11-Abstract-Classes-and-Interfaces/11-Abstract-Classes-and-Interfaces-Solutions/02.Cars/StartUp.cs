using System;

namespace Cars
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            ICar renault = new Renault("Duster", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(renault.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
