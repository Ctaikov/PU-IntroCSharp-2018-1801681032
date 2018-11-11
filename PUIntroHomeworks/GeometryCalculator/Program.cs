using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a figure(triangle, square, radians):");
            string option = Console.ReadLine();
            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter the triangle's side:");
                    double triangleSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the triangle's height:");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The triangle's area is {TriangleArea(triangleSide, triangleHeight)}.");
                    break;
                case "square":
                    Console.WriteLine("Enter the square's side:");
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The square's area is {SquareArea(squareSide)}.");
                    break;
                case "radians":
                    Console.WriteLine("Enter the degrees you want to transform:");
                    double degreesIntoRadians = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The radians is {Radians(degreesIntoRadians)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static double TriangleArea(double triSide, double triHeight)
        {
            double triArea=(triSide*triHeight)/2;
            return triArea;
        }
        static double SquareArea(double sqSide)
        {
            double sqArea = sqSide * sqSide;
            return sqArea;
        }
        static double Radians(double radDegree)
        {
            double rad = (Math.PI / 180) * radDegree;
            return rad;
        }
    }
}
