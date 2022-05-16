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
            //Asking the user to input the CMs they'd like to convert to inches
            Console.WriteLine("Enter the measurement in CMs you'd like to convert to inches: ");
            double inputCMs = double.Parse(Console.ReadLine());

            //Calling the InchEquivalent method and providing CMs as input
            double result = InchEquivalent(inputCMs);

            //Displaying the result to the user
            Console.WriteLine("{0} CMs is equal to {1} inches", inputCMs, result);
        }

        //Method to convert CMs to inches. Takes the users CMs as input
        public static double InchEquivalent(double centimeters)
        {
            double inches = centimeters * 0.394;
            return inches;
        }
    }
}
