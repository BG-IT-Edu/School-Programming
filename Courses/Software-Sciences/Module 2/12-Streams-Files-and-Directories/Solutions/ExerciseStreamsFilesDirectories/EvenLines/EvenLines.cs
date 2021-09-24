using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    string replacedSymbols = ReplaceSymbols(line);
                    string reversedLine = ReverseWords(replacedSymbols);

                    if (counter % 2 == 0)
                    {
                        sb.AppendLine(reversedLine);
                    }

                    line = reader.ReadLine();
                    counter++;
                }
            }

            return sb.ToString().TrimEnd();
        }
        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSymbols(string line)
        {
            return line.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }

}
