//Q5
//Write a C# program that asks the user to enter the age of 10 post-grad students
//and read the age in an array. Write a method that calculates the average of all ages in the array.
//Invoke this method and print the result.

using System;

namespace MethodsExercises
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int result = averageAge();
            Console.WriteLine($"The average age is: {result}");

        }

        public static int averageAge()
        {
            int[] ageArray = new int[10];
            int aveAge = 0;

            for (int i = 0; i < ageArray.Length; i++)
            {
                Console.WriteLine("Enter an age: ");
                ageArray[i] = int.Parse(Console.ReadLine());
            }

            foreach (int age in ageArray)
            {
                aveAge = aveAge + age;
            }

            return aveAge / ageArray.Length;
        }
    }
}
