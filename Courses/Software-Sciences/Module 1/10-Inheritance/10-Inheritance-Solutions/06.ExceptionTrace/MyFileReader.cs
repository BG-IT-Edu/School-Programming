using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExceptionTrace
{
    public class MyFileReader
    {
        private string path;

        public MyFileReader(string path)
        {
            this.Path = path;
        }

        public string Path
        {
            get { return path; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Path or File Name.");
                }
                path = value;
            }
        }

        public void ReadAndSum()
        {
            string[] inputFromFile = File.ReadAllLines(this.Path);

            List<int> numbers = new List<int>();

            int countRow = 0;

            foreach (var value in inputFromFile)
            {
                countRow++;
                try
                {
                    int currentNum = int.Parse(value);
                    numbers.Add(currentNum);

                }
                catch (Exception)
                {
                    throw new ArgumentException($"Error: On the line {countRow} of the file the value was not in the correct format.");
                }
            }
            Console.WriteLine($"The sum of all correct numbers is: {numbers.Sum()}");
        }
    }
}
