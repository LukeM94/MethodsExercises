//Q3
//Write a method which returns the area of a circle, given its radius as an argument.
//A simple call is:
//double a = AreaCircle(1.25);
//Invoke it in the main method.

using System;

namespace MethodsExercises
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double inputRadius = double.Parse(Console.ReadLine());

            double result = AreaCircle(inputRadius);
            Console.WriteLine($"The area of your circle is: {result}");
        }

        public static double AreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
