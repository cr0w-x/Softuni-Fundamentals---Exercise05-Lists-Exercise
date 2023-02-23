using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

            input.Reverse();
            List<int> num = new List<int>();

            foreach (var number in input)
            {
                num.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(" ", num));
        }
    }
}
