using System;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The highest number is {GetHighest(firstNumber, secondNumber, thirdNumber)}.");
        }
        static int GetHighest(int firstNumber, int secondNumber, int thirdNumber)
        {
            if(firstNumber>secondNumber && firstNumber>thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber>firstNumber && secondNumber>thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}
