using System;
using System.Text;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new StringBuilder();

            var bombStrength = 0;

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    bombStrength += int.Parse(item.ToString());
                }

                if (item == '>')
                {
                    result.Append(item);
                }
                else
                {
                    if (bombStrength == 0)
                    {
                        result.Append(item);
                    }
                    else
                    {
                        bombStrength--;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
