using System;

namespace Studio_17_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.WriteLine("Enter a radius:");
            double chosenRadius = Double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * chosenRadius * chosenRadius;
            Console.WriteLine($"Area: {Math.Round(areaOfCircle, 3)}");
            //circumference and diameter
            double circumference = 2 * Math.PI * chosenRadius;
            Console.WriteLine($"Circumference: {Math.Round(circumference, 3)}");
            double diameter = 2 * chosenRadius;
            Console.WriteLine($"Diameter: {Math.Round(diameter, 3)}");
            //road trip
            Console.WriteLine("Enter the mpg of your vehicle:");
            double mpg = Double.Parse(Console.ReadLine());
            double usedGallons = circumference / mpg;
            Console.WriteLine($"It will take {Math.Round(usedGallons, 1)} gallons to make the trip.");
        }
    }
}
