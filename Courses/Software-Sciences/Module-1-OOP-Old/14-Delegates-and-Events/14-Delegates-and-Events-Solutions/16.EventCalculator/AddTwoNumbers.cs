using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalculator
{
   public class AddTwoNumbers
    {
        public delegate void OddNumberDelegate(); //Declared Delegate     
        public event OddNumberDelegate OddNumberEvent; //Declared Events

        public void Add( int num1, int num2)
        {
            int result;
            result = num1 + num2;
            Console.WriteLine(result);

            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (OddNumberEvent != null))
            {
                OddNumberEvent(); //Raised Event
            }
        }
    }
}
