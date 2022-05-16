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
            //Asking the user to input the radius of the circle
            Console.WriteLine("Enter the radius of the circle: ");
            double inputRadius = double.Parse(Console.ReadLine());

            //Calculating the area of the circle by calling the AreaCircle method. Providing the radius as an input
            double result = AreaCircle(inputRadius);

            //Displaying the area of the circle to the user
            Console.WriteLine($"The area of your circle is: {result}");
        }

        //Method to calculate the area of the circle. Takes the radius as an input and returns the area
        public static double AreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
