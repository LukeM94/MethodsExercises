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
            //Declaring an int variable called result that stores the value of the averageAge method
            int result = AverageAge();

            //Displaying the average age of the 10 students to the user
            Console.WriteLine($"The average age is: {result}");

        }

        //Method to calculate the average age of 10 students
        public static int AverageAge()
        {
            //Declaring & initialising an array of length 10, to hold the ages of the students
            int[] ageArray = new int[10];
            int aveAge = 0;

            //Loop to prompt the user to add 10 ages to the array
            for (int i = 0; i < ageArray.Length; i++)
            {
                Console.WriteLine("Enter an age: ");
                ageArray[i] = int.Parse(Console.ReadLine());
            }

            //Looping through the array to add each age to a variable, aveAge
            foreach (int age in ageArray)
            {
                aveAge = aveAge + age;
            }

            //Returning the average age by dividing the sum of all the ages in the array by the length of the array (10)
            return aveAge / ageArray.Length;
        }
    }
}
