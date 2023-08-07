using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class SongsQueue
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", ",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray());

            while (songs.Count > 0)
            {

                Queue<string> cmd = new Queue<string>(Console.ReadLine().Split(' ').ToArray());

                string command = cmd.Dequeue();
                string song = string.Join(' ', cmd.ToArray());

                switch (command)
                {
                    case "Add":
                        {
                            if (!songs.Contains(song))
                            {
                                songs.Enqueue(song);
                            }
                            else
                            {
                                Console.WriteLine($"{song} is already contained!");
                            }
                            break;
                        }
                    case "Play":
                        {
                            if (songs.Count > 0)
                            {
                                songs.Dequeue();
                                if (songs.Count == 0)
                                {
                                    Console.WriteLine("No more songs!");
                                }
                            }

                            break;
                        }
                    case "Show":
                        {
                            Console.WriteLine(string.Join(", ", songs.ToArray()));
                            break;
                        }
                }
            }
        }
    }
}
