using System;

namespace ExceptionTrace
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                MyFileReader reader1 = new MyFileReader(@"C:\temp\numbers.txt");
                reader1.ReadAndSum();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }

            try
            {
                MyFileReader reader2 = new MyFileReader(@"");
                reader2.ReadAndSum();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
