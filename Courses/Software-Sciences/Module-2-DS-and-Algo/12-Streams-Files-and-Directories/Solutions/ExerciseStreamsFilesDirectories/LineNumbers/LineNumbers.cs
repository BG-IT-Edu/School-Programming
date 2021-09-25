using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            
            string[] outputLines = new string[lines.Length];

            for (var i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int letterCount = line.Count(char.IsLetter);
                int symbolCount = line.Count(char.IsPunctuation);

                outputLines[i] = $"Line {i + 1}: {line} ({letterCount})({symbolCount})";
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
