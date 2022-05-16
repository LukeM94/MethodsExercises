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
            //Prompting the user to enter their salary
            Console.WriteLine("Enter your salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            //Prompting the user to enter how many years they've been working
            Console.WriteLine("Enter the number of years you've worked: ");
            int years = int.Parse(Console.ReadLine());

            //Declaring a variable, result, to hold the value returned by the DisplayEarnings method
            decimal result = DisplayEarnings(salary, years);

            //Displaying the total to the user
            Console.WriteLine($"Your total earnings are: EUR {result}");
        }

        //Method to calculate the users total earnings. Takes their salary and the number of years worked as inputs. Returns their total earnings
        public static decimal DisplayEarnings(decimal employeeSalary, int yearsWorked)
        {
            decimal totalEarnings = employeeSalary * yearsWorked;
            return totalEarnings;
        }
    }
}
