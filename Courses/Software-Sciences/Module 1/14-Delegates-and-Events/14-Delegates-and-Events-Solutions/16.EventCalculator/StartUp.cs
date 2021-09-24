using System;

namespace EventCalculator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] numbers = Console.ReadLine().Split();
            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            AddTwoNumbers calculator = new AddTwoNumbers();
            //Event gets binded with delegates
            calculator.OddNumberEvent += new AddTwoNumbers.OddNumberDelegate(EventMessage);
            calculator.Add(firstNumber, secondNumber);

        }
        //Delegates calls this method when event raised.
        static void EventMessage()
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }

    }
}
