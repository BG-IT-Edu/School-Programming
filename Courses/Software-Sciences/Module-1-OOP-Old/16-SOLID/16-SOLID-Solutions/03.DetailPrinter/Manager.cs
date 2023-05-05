using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : IWorker
    {
        public Manager(string name, ICollection<string> documents)
        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public string Name { get ; set ; }
        public IReadOnlyCollection<string> Documents { get; set; }
        public override string ToString()
        {
            return this.Name + Environment.NewLine + string.Join(Environment.NewLine, Documents);
        }
    }
}
