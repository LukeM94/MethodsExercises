//Q1
//Write a method named DisplayEarnings, with two integer parameters representing
//an employee’s salary, and the number of years they have worked. This method should display
//their total earnings on the console when invoked

using System;

namespace MethodsExercises
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary: ");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of years you've worked: ");
            int years = int.Parse(Console.ReadLine());

            int result = DisplayEarnings(salary, years);
            Console.WriteLine($"Your total earnings are: {result}");
        }

        public static int DisplayEarnings(int employeeSalary, int yearsWorked)
        {
            int totalEarnings = employeeSalary * yearsWorked;
            return totalEarnings;
        }
    }
}
