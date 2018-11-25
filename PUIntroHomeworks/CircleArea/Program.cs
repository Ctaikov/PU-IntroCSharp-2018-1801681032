using System;
using System.Text;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double radius = rand.Next(33, 187);
            double circleArea=Math.PI*(Math.Pow(radius,2));
            Console.WriteLine($"The circle's random radius is {radius}.");
            Console.WriteLine($"The circle's area is: {Math.Round(circleArea,2)}.");
        }
    }
}
