using System;

namespace ConsoleKeyEvent
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressKeyA += new PressKeyEvent(PressKeyAWriter);
            keyboard.PressKeyB += PressKeyBWriter;

            while (true)
            {
                keyboard.Start();
            }
        }
        static private void PressKeyAWriter()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You pressed the 'A' key.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyBWriter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You pressed the 'B' key.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
