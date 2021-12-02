using System;
using System.Collections.Generic;
using System.Linq;

namespace RightTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "5";

            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    Enumerable
                    .Range(1,int.Parse(input))
                    .Select(x => $"{string.Concat(Enumerable.Repeat(Enumerable.Range(1, int.Parse(input)).Reverse().ToArray()[x - 1], x))}")
                )    
            );
        }
    }
}
