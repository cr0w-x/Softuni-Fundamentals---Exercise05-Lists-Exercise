using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());            
            string input;

            do
            {
                input = Console.ReadLine();
                List<string> tempList = input.Split().ToList();
                if (input.Contains("Add"))
                {
                    
                    for (int i = 0; i<tempList.Count; i++)
                    {
                        
                        if(int.TryParse(tempList[i], out int tempVar0))
                        {
                            listOfWagons.Add(tempVar0);                            
                        }               
                    }
                }                
                if (int.TryParse(input, out int tempVar1))
                {
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + tempVar1 <= maxCapacity)
                        {
                            listOfWagons[i] += tempVar1;
                            break;
                        }
                    } 
                }
            }            
            while (input != "end");            
            Console.WriteLine(String.Join(" ", listOfWagons));
        }
    }
}
