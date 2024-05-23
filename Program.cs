using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Change_List
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string comands;
            while ((comands = Console.ReadLine()) != "end")
            {
                string[] argument = comands.Split();
                int index;
                switch (argument[0])
                {
                    case "Insert":
                        int item = int.Parse(argument[1]);
                        index = int.Parse(argument[2]);
                        list.Insert(index, item);
                        break;
                    case "Delete":
                        item = int.Parse(argument[1]);
                        list.Remove(item);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
