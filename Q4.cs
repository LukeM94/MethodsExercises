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
            Console.WriteLine("Enter a number to increment: ");
            int inputNum = int.Parse(Console.ReadLine());

            double result = Increment(inputNum);
            Console.WriteLine($"Your incremented number is: {result}");
        }

        public static int Increment(int num)
        {
            int incrementedNum = num + 1;
            return incrementedNum;
        }
    }
}
