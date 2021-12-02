using System;
using System.Linq;

namespace EvenOddSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "8,7,9,3,11,6,2,18";
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    input
                    .Split(",")
                    .Select(x => int.Parse(x))
                    .GroupBy(x => x % 2 == 0)
                    .OrderBy(x => x)
            );

            Console.ReadLine();

        }
    }
}
