using System;

namespace _02._Rainer
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //Read the input and parse it into an int array
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //Create an array for the initial raindrop states which we will use
            //to store the initial values
            //use LINQ Take() method to take length - 1 elements, skipping the last element.
            int[] initialRaindropStates = inputNumbers.Take(inputNumbers.Length - 1).ToArray();
            //Create an array which we will use for the program - the current raindrop states
            //Just use .ToArray() method, it instantiates a new array. (its like a copy algorithm)
            int[] currentRaindropStates = initialRaindropStates.ToArray();

            //Take the last element from the input numbers, this is our initial index
            int currentIndex = inputNumbers.Last();

            //Just a boolean variable to track the state of our program
            bool hasGottenWet = false;

            //Steps counter
            int steps = 0;

            //A while loop
            while (!hasGottenWet)
            {
                //First, we decrement all elements from the sequence
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    currentRaindropStates[i]--;
                }

                //Then we check if there is an element equal to 0 and if Donald is on it
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i] == 0 && i == currentIndex)
                    {
                        //If he is, we break the loop and do nothing more!
                        hasGottenWet = true;
                        break;
                    }
                }

                //Break the overall loop, if hasGottenWet variable is true
                if (hasGottenWet)
                {
                    break;
                }

                //If Donald has not gotten wet, we check all elements for 0 values
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i] == 0)
                    {
                        //If an element is 0, we return it to its initial value, using the initial values array
                        currentRaindropStates[i] = initialRaindropStates[i];
                    }    
                }

                //We read next index, and increment the steps
                currentIndex = int.Parse(Console.ReadLine());
                steps++;
            }

            //Print the current state of the sequence, joined by space, and the steps
            Console.WriteLine(string.Join(" ", currentRaindropStates));
            Console.WriteLine(steps);
        }
    }
}