namespace _01.ListyIterator
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var x = new ListyIterator<string>();
            var createCommand = Console.ReadLine().Split().ToArray();
            var items = createCommand.Skip(1).ToArray();
            x.Create(items);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    return;
                }
                else if (command == "Move")
                {
                    Console.WriteLine(x.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(x.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        x.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}