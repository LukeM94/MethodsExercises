//Q6
//Write the simple Calc program which is given below with option '5' to exit. Write a
//program which displays a menu to the user. The menu should look similar to the following:
//Welcome to the SimpleCacl
//Press 1 to add two numbers
//Press 2 to subtract two numbers
//Press 3 to divide two numbers
//Press 4 to multiple two numbers
//Read in the selection from the user and then ask the user for two numbers.
//Print the result to the user.
//b. Also ask the user if they want to continue or quit.(use loop)
//c.Using the simple calculator, create methods to perform the following
//Add which accepts two numbers
//Subtract which accepts two numbers
//Divide which accepts two numbers
//Multiple which accepts two number

using System;

namespace MethodsExercises
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            //Present the options to the user
            Console.WriteLine("Welcome to the SimpleCacl");
            Console.WriteLine("Press 1 to add two numbers");
            Console.WriteLine("Press 2 to subtract two numbers");
            Console.WriteLine("Press 3 to divide two numbers");
            Console.WriteLine("Press 4 to multiply two numbers");
            Console.WriteLine("Press 5 to exit");
            
            //Take the users selection
            string userSelection = Console.ReadLine();

            int numOne;
            int numTwo;

            //Using a switch statement to call the appropriate calculation method based on the users selction
            switch (userSelection)
            {
                //Call the Add method
                case "1":
                    Console.WriteLine("You selected add!");

                    //Ask the user to input their first number
                    Console.WriteLine("Enter your first number: ");
                    numOne = int.Parse(Console.ReadLine());
                    //Ask the user to input their second number
                    Console.WriteLine("Enter your second number: ");
                    numTwo = int.Parse(Console.ReadLine());

                    int addResult = addNumbers(numOne, numTwo);
                    Console.WriteLine($"The result is {addResult}");
                    break;
                //Call the Subtract method
                case "2":
                    Console.WriteLine("You selected subtract!");

                    //Ask the user to input their first number
                    Console.WriteLine("Enter your first number: ");
                    numOne = int.Parse(Console.ReadLine());
                    //Ask the user to input their second number
                    Console.WriteLine("Enter your second number: ");
                    numTwo = int.Parse(Console.ReadLine());

                    int subtractResult = subtractNumbers(numOne, numTwo);
                    Console.WriteLine($"The result is {subtractResult}");
                    break;
                //Call the Divide method
                case "3":
                    Console.WriteLine("You selected divide!");

                    //Ask the user to input their first number
                    Console.WriteLine("Enter your first number: ");
                    numOne = int.Parse(Console.ReadLine());
                    //Ask the user to input their second number
                    Console.WriteLine("Enter your second number: ");
                    numTwo = int.Parse(Console.ReadLine());

                    int divideResult = divideNumbers(numOne, numTwo);
                    Console.WriteLine($"The result is {divideResult}");
                    break;
                //Call the Multiply method
                case "4":
                    Console.WriteLine("You selected multiply!");

                    //Ask the user to input their first number
                    Console.WriteLine("Enter your first number: ");
                    numOne = int.Parse(Console.ReadLine());
                    //Ask the user to input their second number
                    Console.WriteLine("Enter your second number: ");
                    numTwo = int.Parse(Console.ReadLine());

                    int multiplyResult = multiplyNumbers(numOne, numTwo);
                    Console.WriteLine($"The result is {multiplyResult}");
                    break;
                //Handling the users request to exit the calculator
                case "5":
                    Console.WriteLine("You selected exit :( Bye bye!");
                    break;
                //Handling some errors from the users input
                default:
                    Console.WriteLine("Something went wrong. Are you sure you entered 1-5? Go on, have another go!");
                    break;
            }
        }

        //Method to Add the numbers. Takes the users two numbers as parameters and returns them added
        public static int addNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        //Method to Subtract the numbers. Takes the users two numbers as parameters and returns them subtracted
        public static int subtractNumbers(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        //Method to Divide the numbers. Takes the users two numbers as parameters and returns them divided
        public static int divideNumbers(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        //Method to Multiply the numbers. Takes the users two numbers as parameters and returns them multiplied
        public static int multiplyNumbers(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
    }
}
