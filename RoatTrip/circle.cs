using System;
using System.Collections.Generic;
using System.Text;

namespace RoatTrip
{
    class circle
    {
        public static double area(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }

        public static double diameter(double radius)
        {
            return (2 * radius);
        }

        public static double circumference(double radius)
        {
            return Math.Round((radius * 2 * Math.PI),2);
        }
    }
}
