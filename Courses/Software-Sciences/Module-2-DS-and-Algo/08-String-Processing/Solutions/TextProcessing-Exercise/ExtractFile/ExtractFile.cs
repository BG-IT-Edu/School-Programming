using System;

namespace ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("\\");

            var file = input[input.Length - 1].Split(".");

            var fileName = file[0];
            var extension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
