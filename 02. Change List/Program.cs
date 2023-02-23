using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmd = input.Split();
                string currcmd = cmd[0];
                if (currcmd == "Delete")
                {
                    int number = int.Parse(cmd[1]);
                    num.RemoveAll(x => x == number);
                }
                else if (currcmd == "Insert")
                {
                    int number = int.Parse(cmd[1]);
                    int index = int.Parse(cmd[2]);

                    num.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(" ", num));
        }
    }
}
