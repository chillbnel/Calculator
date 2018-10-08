using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToInput = 2; //determines the amount of numbers the user will input into the calculator
            double[] inputedNumbers = new double[numbersToInput]; //array hold the numbers entered my the user

            Console.WriteLine("Welcome to Brian's totally awesome console calulator!");//lets the user know what this thing is all about

            for (int i = 0; i < numbersToInput; i++)//loop runs prompting the user a number, iterates amount of times we hard coded into numbersToInput
            {
                Console.WriteLine("Please enter a number:");
                inputedNumbers[i] = int.Parse(Console.ReadLine());//stores the user's input into the array
            }

            Add(inputedNumbers, numbersToInput); //calls the Add function, passes the inputed numbers via an array
            Subtract(inputedNumbers, numbersToInput); //calls the Subtract function, passes the inputed numbers via an array
            Multiply(inputedNumbers, numbersToInput); //calls the Multiply function, passes the inputed numbers via an array
            Divide(inputedNumbers, numbersToInput); //calls the Divide function, passes the inputed numbers via an array

        }
        
        static double Add(double[] numbersToAdd, int numbersInputed)
        {
            double tempAdd = 0;

            for (int i = 0; i < numbersInputed; i++) //loop runs adding all the numbers in passed into the function
            {
                tempAdd = tempAdd + numbersToAdd[i];
            }

            Console.WriteLine("The addition of your "+ numbersInputed+" numbers is " + tempAdd);//displays addition results to the user
            return tempAdd; //returns the results incase we need to use them later on
        }

        static double Subtract(double[] numbersToSubtract, int numbersInputed)
        {
            double tempSubtract = 0;

            for (int i = 0; i < numbersToSubtract.Length; i++) //loop runs subtracting all the numbers in passed into the function
            {
                tempSubtract = numbersToSubtract[i] - tempSubtract;
            }

            Console.WriteLine("The subtraction of your " + numbersInputed + " numbers is " + tempSubtract); //displays subtraction results to the user
            return tempSubtract; //returns the results incase we need to use them later on
        }

        static double Multiply(double[] numbersToMultiply, int numbersInputed)
        {
            double tempMultiply = 1;

            for (int i = 0; i < numbersToMultiply.Length; i++) //loop runs multiplying all the numbers in passed into the function
            {
                tempMultiply = tempMultiply * numbersToMultiply[i];
            }

            Console.WriteLine("The multiplication of your " + numbersInputed + " numbers is " + tempMultiply); //displays multiplication results to the user
            return tempMultiply; //returns the results incase we need to use them later on
        }

        static double Divide(double[] numbersToDivide, int numbersInputed)
        {
            double tempDivide = numbersToDivide[0];

            for (int i = 1; i < numbersToDivide.Length; i++) //loop runs dividing all the numbers passed into the function; starts at the second #
            {
                tempDivide = tempDivide / numbersToDivide[i];
            }

            Console.WriteLine("The division of your " + numbersInputed + " numbers is " + tempDivide); //displays division results to the user
            return tempDivide; //returns the results incase we need to use them later on
        }

    }
}
