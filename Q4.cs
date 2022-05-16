//Q4
//Write a method called increment, which adds 1 to its integer argument. An example call is:
//int n = 3;
//int a = increment(n);

using System;

namespace MethodsExercises
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            //Asking the user to enter a number to increment
            Console.WriteLine("Enter a number to increment: ");
            int inputNum = int.Parse(Console.ReadLine());

            //Calling the Increment method and providing the users number as an input
            double result = Increment(inputNum);
            Console.WriteLine($"Your incremented number is: {result}");
        }

        //Method to increment the number. Takes the users number as an input and returns the incremented number
        public static int Increment(int num)
        {
            int incrementedNum = num + 1;
            return incrementedNum;
        }
    }
}
