//Q7
//You have been asked to write a program for a local goods transport company. The company has the following pricing structure:
//Millage Rate 0-100 Miles: €0.50 per mile
//101-200 Miles: €0.40 per mile
//201+ Miles: €0.30 per mile
//Example:
//250 miles would cost €105 (€50+€40+€15)
//Weight Rate 0-100 Kgs: €0.33 per Kg
//101-200 Kgs: €0.23 per Kg
//201+ Kgs: €0.17 per Kg
//Example:
//250 Kgs would cost €64.50 (€33+€23+€8.50)
//Regular Customer Discount 7.5% off total bill
//The program requires the clerk to enter the following information:
//·How many miles must the item be transported?
//·What is the weight of the items being transported?

using System;

namespace MethodsExercises
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many miles must the item be transported: ");
            double transportMiles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight of the item being transported: ");
            double itemWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Is this a regular customer? Yes/No");
            string regCustomer = Console.ReadLine();

            double outputTotalCost = calculateItemCost(transportMiles, itemWeight);

            if (regCustomer == "Yes")
            {
                outputTotalCost = calculateDiscount(outputTotalCost);
            }

            Console.WriteLine("The total cost is: EUR {0}", outputTotalCost);
        }

        //Function to calculate the discount if the customer's regular
        public static double calculateDiscount(double outputTotalCost)
        {
            double discount = (outputTotalCost / 100) * 7.5;
            outputTotalCost = outputTotalCost - discount;
            return outputTotalCost;
        }

        //Function to calculate the item cost
        public static double calculateItemCost(double transportMiles, double itemWeight)
        {
            double costPerMile = 0.0;
            double costPerKg = 0.0;

            if (transportMiles >= 0 && transportMiles <= 100)
            {
                costPerMile = 0.50;

            }
            else if (transportMiles >= 101 && transportMiles <= 200)
            {
                costPerMile = 0.40;

            }
            else if (transportMiles >= 201)
            {
                costPerMile = 0.30;

            }

            if (itemWeight >= 0 && itemWeight <= 100)
            {
                costPerKg = 0.33;

            }
            else if (itemWeight >= 101 && itemWeight <= 200)
            {
                costPerKg = 0.23;

            }
            else if (itemWeight >= 201)
            {
                costPerKg = 0.17;

            }

            double totalCostPerMile;
            totalCostPerMile = transportMiles * costPerMile;

            double totalCostPerKg;
            totalCostPerKg = itemWeight * costPerKg;

            double totalCost = totalCostPerMile + totalCostPerKg;

            return totalCost;
        }
    }
}
