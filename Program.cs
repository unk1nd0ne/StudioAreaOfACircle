using Microsoft.VisualBasic;
using System;

namespace StudioAreaOfACircle
{
    class Program
    {
        private static void Main()
        {
            double radius = 0;
            string input;
            double mpg = 0;
            double gallonsOfGas;

            while (radius <= 0)
            {
                Console.Write("Enter a radius: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out radius))
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(Circle.CalculateArea(radius), 3));
            
            Console.WriteLine("The circumference is: " + Math.Round(Circle.CalculateCircumference(radius), 3) + " and the diameter is: " + Math.Round(Circle.CalculateDiameter(radius), 3));

            while (mpg <= 0)
            {
                Console.Write("Enter your MPG: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out mpg))
                {
                    Console.WriteLine("Please enter a number!");
                }
            }

            gallonsOfGas = Circle.CalculateCircumference(radius) / mpg;

            Console.WriteLine("At " + mpg + " MPG, you will use " + Math.Round(gallonsOfGas, 3) + " gallons of gas.");

        }
    }
}
