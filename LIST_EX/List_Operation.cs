using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] argument = comand.Split(" ");
                switch (argument[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(argument[1]));
                        break;
                    case "Insert":
                        int item = int.Parse(argument[1]);
                        int insertIndex = int.Parse(argument[2]);
                        if (IsNotValidIndex(insertIndex, numbers.Count))
                        {
                            Console.WriteLine(" Invalid index");
                            continue;
                        }
                        numbers.Insert(insertIndex, item);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(argument[1]);
                        if (IsNotValidIndex(removeIndex, numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Remove(removeIndex);
                        break;
                    case "Shift":
                        string direction = argument[1];
                        int count = int.Parse(argument[2]);
                        Shift(numbers, direction, count);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
        private static bool IsNotValidIndex(int index, int count)
        {
            return index < 0 || index >= count;
        }
        private static void Shift (List<int>numbers, string direction, int count)
        {
            count %= numbers.Count;
            if(direction == "left")
            {
                List<int> shiftedPart = numbers.GetRange(0, count);
                numbers.RemoveRange(0, count);
                numbers.InsertRange(numbers.Count, shiftedPart);
            }
            else if(direction == "right")
            {
                List<int> shiftedPart = numbers.GetRange(numbers.Count - count, count);
                numbers.RemoveRange(numbers.Count - count, count);
                numbers.InsertRange(0, shiftedPart);
            }
        }

    }
}
