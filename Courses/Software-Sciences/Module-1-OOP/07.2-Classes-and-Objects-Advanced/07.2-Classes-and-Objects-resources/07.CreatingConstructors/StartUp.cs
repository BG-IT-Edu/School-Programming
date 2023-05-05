using System;
using ClassesEmployee;

namespace ClassesEmployee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Employee someone = new Employee();
            someone.Name = "Dan";
            someone.Age = 20;
            Employee someoneTwo = new Employee();
            someoneTwo.Name = "Joey";
            someoneTwo.Age = 18;
        }
    }
}

