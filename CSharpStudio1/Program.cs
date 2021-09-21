using System;

namespace CSharpStudio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");

            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            area = Math.Round(area, 2);

            Console.WriteLine($"The area of a circle of radius {radius} is: {area}");

            double diameter = (2 * radius);

            double circumference = Math.Round((diameter * Math.PI),2);

            Console.WriteLine($"The diameter of a circle of radius {radius} is: {diameter}");
            Console.WriteLine($"The circumference of a circle of radius {radius} is: {circumference}");


        }
    }

}
