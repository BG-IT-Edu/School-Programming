using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Program
    {
        static void Main()
        {
            var listOfWorkers = new List<IWorker>();
            IWorker worker = null;

            worker = new Employee("Gosho employee");
            listOfWorkers.Add(worker);

            var documents = new List<string>() {"DocumentOne", "DocumentTwo", "DocumentThree", "DocumentFour" };
            worker = new Manager("Pesho manager", documents);
            listOfWorkers.Add(worker);

            worker = new ExampleWorker("Bobby example", 24);
            listOfWorkers.Add(worker);

            DetailsPrinter detailsPrinter = new DetailsPrinter(listOfWorkers);
            detailsPrinter.PrintDetails();
        }
    }
}
