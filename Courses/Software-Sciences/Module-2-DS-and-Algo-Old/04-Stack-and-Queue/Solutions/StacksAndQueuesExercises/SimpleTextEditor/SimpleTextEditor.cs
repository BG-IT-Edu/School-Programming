using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            Stack<string> previosText = new Stack<string>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "1")
                {
                    previosText.Push(text.ToString());
                    text.Append(command[1]);
                }
                else if (command[0] == "2")
                {
                    int countSymbolToRemove = int.Parse(command[1]);
                    previosText.Push(text.ToString());
                    text.Remove(text.Length - countSymbolToRemove, countSymbolToRemove);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command[0] == "4")
                {
                    text.Clear();
                    text.Append(previosText.Pop());
                }

            }
        }
    }
}
