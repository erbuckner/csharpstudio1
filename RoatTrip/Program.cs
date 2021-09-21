using System;

namespace RoatTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the MPG for your vehicle: ");
            double mpg = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of your trip in miles: ");
            double radius = double.Parse(Console.ReadLine());

            double lengthofTrip = circle.circumference(radius);

            double gallonsOfGas = (lengthofTrip / mpg);

            Console.WriteLine($"Gallons required for trip around circle is: {gallonsOfGas}");

        }
    }
}
