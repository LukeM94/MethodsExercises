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
//·Is this a regular customer?
//The program should then display the Total amount for the bill. If a discount was applied show
//how much the value of the discount is. Write appropriate methods to calculate the each cost.
//Then add the cost to calculate total bill.

using System;

namespace MethodsExercises
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            //Asking the user to input how many miles the item is being transported
            Console.WriteLine("Enter how many miles must the item be transported: ");
            double transportMiles = double.Parse(Console.ReadLine());

            //Asking the user to enter the weight of the item being transported
            Console.WriteLine("Enter the weight of the item being transported: ");
            double itemWeight = double.Parse(Console.ReadLine());

            //Asking the user to enter whether this is a regular customer by typing "Yes" OR "No"
            Console.WriteLine("Is this a regular customer? Yes/No");
            string regCustomer = Console.ReadLine();

            //Calling the CalculateItemCost method, with the miles to be transported and item weight as inputs
            //Storing the result in the outputTotalCost variable
            double outputTotalCost = CalculateItemCost(transportMiles, itemWeight);

            //If the customer is a regular, then we call the CalculateDiscount method on the outputTotalCost
            if (regCustomer == "Yes")
            {
                outputTotalCost = CalculateDiscount(outputTotalCost);
            }

            //Displaying the total cost to the user
            Console.WriteLine("The total cost is: EUR {0}", outputTotalCost);
        }

        //Method to calculate the discount if the customer's regular
        public static double CalculateDiscount(double outputTotalCost)
        {
            double discount = (outputTotalCost / 100) * 7.5;
            outputTotalCost = outputTotalCost - discount;
            Console.WriteLine("The discount is: EUR {0}", discount);
            return outputTotalCost;
        }

        //Method to calculate the item cost
        public static double CalculateItemCost(double transportMiles, double itemWeight)
        {
            //Declaring & initialising the variables used in the IF statements below
            double transportMilesCost = 0.0;
            double remainder = 0.0;
            double weightRemainder = 0.0;
            double itemWeightCost = 0.0;

            //IF statement to determine the price to charge per mile
            if (transportMiles >= 0 && transportMiles <= 100)
            {
                transportMilesCost = transportMiles * 0.5;
            }
            else if (transportMiles >= 101 && transportMiles <= 200)
            {
                remainder = transportMiles - 100;
                transportMilesCost = (remainder * 0.4) + 50;
            }
            else if (transportMiles >= 201)
            {
                remainder = transportMiles - 200;
                transportMilesCost = (remainder * 0.3) + 90;
            }

            //IF statement to determine the price to charge for the item weight
            if (itemWeight >= 0 && itemWeight <= 100)
            {
                itemWeightCost = itemWeight * 0.33;

            }
            else if (itemWeight >= 101 && itemWeight <= 200)
            {
                weightRemainder = itemWeight - 100;
                itemWeightCost = (weightRemainder * 0.23) + 33;

            }
            else if (itemWeight >= 201)
            {
                weightRemainder = itemWeight - 200;
                itemWeightCost = (weightRemainder * 0.17) + 56;

            }

            //Assigning the total cost to the totalCost variable
            double totalCost = transportMilesCost + itemWeightCost;

            //Returning the total cost
            return totalCost;
        }
    }
}
