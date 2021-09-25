using System;

class RecursiveDrawing
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Drawing(input);
    }

    private static void Drawing(int index)
    {
        if (index == 0)
        {
            return;
        }

        Console.WriteLine(new string('*', index));

        Drawing(index - 1);

        Console.WriteLine(new string('#', index));
    }
}

