using System;

namespace ClassesEmployee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Dan";
            employee1.Age = 20;

            Employee employee2 = new Employee
            {
                Name = "Joey",
                Age = 18
            };

            Employee employee3 = new Employee
            {
                Name = "Tommy"
            };
            employee3.Age = 43;
        }
    }
}