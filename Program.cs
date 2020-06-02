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
            double mpg = 0;
            double repetitions;

            while (radius <= 0)
            {
                Console.Write("Enter a radius: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out radius))
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            
            area = Circle.CalculateArea(radius);
            circumference = Circle.CalculateCircumference(radius);
            diameter = Circle.CalculateDiameter(radius);

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(area, 3));
            
            Console.WriteLine("The circumference is: " + Math.Round(circumference, 3) + " and the diameter is: " + Math.Round(diameter, 3));

            while (mpg <= 0)
            {
                Console.Write("Enter your MPG: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out mpg))
                {
                    Console.WriteLine("Please enter a number!");
                }
            }

            repetitions = mpg / circumference;

            Console.WriteLine("At " + mpg + " MPG, you can drive " + Math.Round(repetitions, 3) + " times around the circle.");

        }
    }
}
