using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string childName = Console.ReadLine();
            int childAge = int.Parse(Console.ReadLine());

            string motherName = Console.ReadLine();
            int motherAge = int.Parse(Console.ReadLine());

            string fatherName = Console.ReadLine();
            int fatherAge = int.Parse(Console.ReadLine());

            Person mother = new Person(motherName, motherAge);
            Person father = new Person(fatherName, fatherAge);

            Child child = new Child(childName, childAge, mother, father);
            Console.WriteLine(child);

        }
    }
}