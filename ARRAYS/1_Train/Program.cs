using System;

namespace _1_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int countWagon = int.Parse(Console.ReadLine());
            int[] arrayTrain = new int[countWagon];
            int sum = 0;
            for(int i =0; i < countWagon; i++)
            {
                int countPeople= int.Parse(Console.ReadLine());
                arrayTrain[i] = countPeople;
                sum += countPeople;
            }
            Console.WriteLine(string.Join(" ",arrayTrain));
            Console.WriteLine(sum);
        }
    }
}
