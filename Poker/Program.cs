using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    internal class Program
    {
        /// <summary>
        /// 一副鋪克牌亂數洗給4個人
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> pokerList = 
                Enumerable.Range(1, 52)
                .OrderBy(x => new Random().Next())
                .ToList();

            Console.WriteLine(
                string.Join(Environment.NewLine,
                Enumerable.Range(0, 4)
                .GroupBy(x => x % 4)
                .Select(x => $"玩家{x.Key}有{string.Join(",", pokerList.Skip(x.Key * 13).Take(13))}")
                )
            );

            Console.ReadLine();

        }
    }
}
