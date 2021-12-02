using System;
using System.Linq;

namespace ReverseNumber
{
    internal class Program
    {
        /// <summary>
        /// input: 12, 18, 13, 23, 32
        /// output: 32, 23, 13, 18, 12
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input = "12,18,13,23,32";
            Console.WriteLine(
                string.Join(",", input.Split(',').Reverse())
            );

            Console.ReadLine();
        }
    }
}
