using System;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to do some math.");
            Console.WriteLine("------------------------------");
            Console.Write("Enter Xa: ");
            double Xa = double.Parse(Console.ReadLine());
            Console.Write("Enter Ya: ");
            double Ya = double.Parse(Console.ReadLine());
            Console.Write("Enter Xb: ");
            double Xb = double.Parse(Console.ReadLine());
            Console.Write("Enter Yb: ");
            double Yb = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("The points have these coordinates:");
            Console.WriteLine($"Point A({Xa}, {Ya}).");
            Console.WriteLine($"Point B({Xb}, {Yb}).");
            Console.WriteLine("------------------------------");
            double D = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2));
            Console.WriteLine($"The distance between the two points is {D}.");

        }
    }
}
