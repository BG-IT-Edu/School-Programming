using System;
class SquareRoot
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        try
        {
            if (n < 0) throw new Exception("Invalid number.");
            
            Console.WriteLine(Math.Sqrt(n));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}
