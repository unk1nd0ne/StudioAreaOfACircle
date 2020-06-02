using System;
using System.Collections.Generic;
using System.Text;

namespace StudioAreaOfACircle
{
    class Circle
    {
        public static double CalculateArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI; ;
        }
        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius; ;
        }

        public static double CalculateDiameter(double radius)
        {
          return 2 * radius; ;
        }
    }
}
