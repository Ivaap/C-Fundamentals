using System;
using System.Reflection.Metadata;

namespace _4_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintTriangle(count);

        }
        static void PrintTriangle(int count)
        {
            for( int col = 1;  col<=count; col++)
            {
                for(int row =1;row<=col; row++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
            for(int i =1; i <count; i--)
            {
                for (int j =1; j <=i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
