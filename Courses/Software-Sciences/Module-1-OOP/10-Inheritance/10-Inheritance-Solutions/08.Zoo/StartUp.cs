using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string gorillaName = Console.ReadLine();
            string snakeName = Console.ReadLine();
            string lizardName = Console.ReadLine();
            string bearName = Console.ReadLine();

            Gorilla gorilla = new Gorilla(gorillaName);
            Snake snake = new Snake(snakeName);
            Lizard lizard = new Lizard(lizardName);
            Bear bear = new Bear(bearName);

            Console.WriteLine($"Gorilla's name: {gorilla.Name}");
            Console.WriteLine($"Snake's name: {snake.Name}");
            Console.WriteLine($"Lizard's name: {lizard.Name}");
            Console.WriteLine($"Bear's name: {bear.Name}");
        }
    }
}