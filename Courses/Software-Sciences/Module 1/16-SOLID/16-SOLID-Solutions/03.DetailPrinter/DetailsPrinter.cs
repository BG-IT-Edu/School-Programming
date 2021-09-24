using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<IWorker> workers;

        public DetailsPrinter(IList<IWorker> workers)
        {
            this.workers = workers;
        }

        public void PrintDetails()
        {
            foreach (IWorker worker in this.workers)
            {
                PrintWorker(worker);
                Console.WriteLine("----------------");
            }
        }
        private void PrintWorker(IWorker worker)
        {
            Console.WriteLine(worker);
        }
    }
}
