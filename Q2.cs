//Q2
//Write a method which returns the inch equivalent of its centimeter argument.
//An example call is:
//double inches = InchEquivalent(10.5);
//Multiply centimeters by 0.394 to calculate inches. Invoke it in the main method.

using System;

namespace MethodsExercises
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the measurement in CMs you'd like to convert to inches: ");
            double inputCMs = double.Parse(Console.ReadLine());

            double result = InchEquivalent(inputCMs);
            Console.WriteLine("{0} CMs is equal to {1} inches", inputCMs, result);
        }

        public static double InchEquivalent(double centimeters)
        {
            double inches = centimeters * 0.394;
            return inches;
        }
    }
}
