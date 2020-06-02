using System;
using System.Collections.Generic;
using System.Text;

namespace StudioAreaOfACircle
{
    class Circle
    {
        public static double CalculateArea(double radius)
        {
            double area;

            area = Math.Pow(radius, 2) * Math.PI;

            return area;
        }
        public static double CalculateCircumference(double radius)
        {
            double circumference;

            circumference = 2 * Math.PI * radius;

            return circumference;
        }

        public static double CalculateDiameter(double radius)
        {
            double diameter;

            diameter = 2 * radius;

            return diameter;
        }
    }
}
