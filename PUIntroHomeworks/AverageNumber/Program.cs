using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evenNumberCount=0;
            double evenNumberSum=0;
            do
            {
                Console.WriteLine("Enter a number between 1 and 255:");
                number = int.Parse(Console.ReadLine());
                if ((number>=1 && number<256) && number%2==0)
                {
                    evenNumberSum += number;
                    evenNumberCount++;
                }
            } while (number!=0);
            if(evenNumberCount==0)
            {
                Console.WriteLine("Please, enter a number between 1 and 255.");
            }
            else
            {
                Console.WriteLine($"Average {evenNumberSum / evenNumberCount}.");
            }
        }
    }
}
