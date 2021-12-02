using System;
using System.Linq;

namespace ReverseWord
{
    internal class Program
    {
        /// <summary>
        /// input: I Love You
        /// output: I evoL uoY
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input = "I Love You";

            Console.WriteLine(
                string.Join(
                    " ",
                    input.Split(' ').Select(x => string.Concat(x.Reverse()))
                )
            );

            Console.ReadLine();
        }
    }
}
