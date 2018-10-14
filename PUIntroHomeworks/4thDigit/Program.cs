using System;

namespace _4thDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7 digit number:");
            int number = int.Parse(Console.ReadLine());
            if (number<1000000 || number>9999999)
            {
                Console.WriteLine("Your number is not 7 digits long.");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;
                Console.WriteLine($"The 4th digit of {number} is {fourthDigit}.");
            }


        }
    }
}
