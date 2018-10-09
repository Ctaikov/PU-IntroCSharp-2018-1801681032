using System;

namespace TravelToTheSunWithSoundSpeedInWater
{
    class Program
    {
        static void Main(string[] args)
        {
            short speedOfSOundI20DegreeWater = 1481;
            int distanceToSunFromEarth = 149600000;
            double timeNeeded = (double)distanceToSunFromEarth / speedOfSOundI20DegreeWater;
            Console.WriteLine($"Time needed:!{timeNeeded}");
        }
    }
}
