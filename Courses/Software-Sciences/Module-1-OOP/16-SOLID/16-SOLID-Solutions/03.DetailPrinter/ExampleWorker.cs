using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class ExampleWorker : IWorker
    {       
        public string Name { get; set ; }
        private int monthsWorked;

        public ExampleWorker(string name, int monthsWorked)
        {
            this.Name = name;
            this.monthsWorked = monthsWorked;
        }

        public override string ToString()
        {
            return this.Name + Environment.NewLine + this.monthsWorked;
        }
    }
}
