using Microsoft.VisualBasic;
using System;

namespace StudioAreaOfACircle
{
    class Program
    {
        private static void Main()
        {
            double radius = 0;
            double area;
            double circumference;
            double diameter;
            string input;
            double repetitions;

            while (radius <= 0)
            {
                Console.Write("Enter a radius: ");
                input = Console.ReadLine();
                radius = double.Parse(input);
            }
            
            area = Circle.CalculateArea(radius);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(area, 3));
            circumference = Circle.CalculateCircumference(radius);
            diameter = Circle.CalculateDiameter(radius);
            Console.WriteLine("The circumference is: " + Math.Round(circumference, 3) + " and the diameter is: " + Math.Round(diameter, 3));
            Console.Write("Enter you MPG: ");
            input = Console.ReadLine();
            repetitions = double.Parse(input) / circumference;
            Console.WriteLine("At " + input + " MPG, you can drive " + Math.Round(repetitions, 3) + " times around the circle.");

        }
    }
}
