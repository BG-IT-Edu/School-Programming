using System;
using System.Collections.Generic;
using WildFarm.Animals;


namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split();
                Animal animal = CreateAnimal(parts);
                animals.Add(animal);

                string[] foodParts = Console.ReadLine().Split();
                Food food = CreateFood(foodParts);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public static Food CreateFood(string[] foodParts)
        {
            string foodType = foodParts[0];
            int foodQuantity = int.Parse(foodParts[1]);

            Food food = default;

            if (foodType == nameof(Meat))
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == nameof(Vegetable))
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == nameof(Seeds))
            {
                food = new Seeds(foodQuantity);
            }
            else if (foodType == nameof(Fruit))
            {
                food = new Fruit(foodQuantity);
            }
            return food;
        }
        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];
            string name = parts[1];
            double weight = double.Parse(parts[2]);

            Animal animal = default;

            if (type == nameof(Hen))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Mouse))
            {
                string livingRegien = parts[3];
                animal = new Mouse(name, weight, livingRegien);
            }
            else if (type == nameof(Dog))
            {
                string livingRegien = parts[3];
                animal = new Dog(name, weight, livingRegien);
            }
            else if (type == nameof(Tiger))
            {
                string livingRegion = parts[3];
                string breed = parts[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Cat))
            {
                string livingRegion = parts[3];
                string breed = parts[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            return animal;
        }
    }
    
}
