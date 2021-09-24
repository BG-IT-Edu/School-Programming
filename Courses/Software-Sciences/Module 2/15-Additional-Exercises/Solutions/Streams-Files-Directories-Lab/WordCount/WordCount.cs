using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader(wordsFilePath))
            {
                string[] words = wordsReader.ReadToEnd().ToLower().Split();

                foreach (var word in words)
                {
                    if (!wordsCounts.ContainsKey(word))
                    {
                        wordsCounts.Add(word, 0);
                    }
                }
            }

            using (var textReader = new StreamReader(textFilePath))
            {
                string[] text = textReader.ReadToEnd().ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in text)
                {
                    if (wordsCounts.ContainsKey(word))
                    {
                        wordsCounts[word] += 1;
                    }
                }
            }

            List<string> items = new List<string>();
            foreach (var item in wordsCounts.OrderByDescending(v => v.Value))
            {
               items.Add($"{item.Key} - {item.Value}");
            }

            string output = string.Join(Environment.NewLine, items);
            File.WriteAllText(outputFilePath, output);
        }
    }
}
