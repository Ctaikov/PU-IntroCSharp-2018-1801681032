using System;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyNumbersCount = 0;
            int unluckyNumberCount = 0;
            for (int i=0; i<1000000;i++)
            {
                if((i / 100000 + i % 100000 / 10000 + i % 100000 % 10000 / 1000)==(i % 100000 % 10000 % 1000 / 100 + i % 100000 % 10000 % 1000 % 100 / 10 + i % 10))
                {
                    Console.WriteLine(i);
                    luckyNumbersCount++;
                }
                else
                {
                    unluckyNumberCount++;
                }
            }
            Console.WriteLine($"The total number of ticket is {luckyNumbersCount+unluckyNumberCount}.");
            Console.WriteLine($"The total number of lucky tickets is {luckyNumbersCount}.");
            Console.WriteLine($"The total number of unlucky tickets is {unluckyNumberCount}.");
        }
    }
}
