using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToInput = 2;
            double[] inputedNumbers = new double[numbersToInput];

            Console.WriteLine("Welcome to Brian's totally awesome console calulator!");

            for (int i = 0; i < numbersToInput; i++)
            {
                Console.WriteLine("Please enter a number:");
                inputedNumbers[i] = int.Parse(Console.ReadLine());
            }

            Add(inputedNumbers, numbersToInput);
            Subtract(inputedNumbers, numbersToInput);
            Multiply(inputedNumbers, numbersToInput);
            Divide(inputedNumbers, numbersToInput);
     
        }
        
        static double Add(double[] numbersToAdd, int numbersInputed)
        {
            double tempAdd = 0;

            for (int i = 0; i < numbersInputed; i++)
            {
                tempAdd = tempAdd + numbersToAdd[i];
            }

            Console.WriteLine("The addition of your "+ numbersInputed+" numbers is " + tempAdd);
            return tempAdd;
        }

        static double Subtract(double[] numbersToSubtract, int numbersInputed)
        {
            double tempSubtract = 0;

            for (int i = 0; i < numbersToSubtract.Length; i++)
            {
                tempSubtract = tempSubtract - numbersToSubtract[i];
            }

            Console.WriteLine("The subtraction of your " + numbersInputed + " numbers is " + tempSubtract);
            return tempSubtract;
        }

        static double Multiply(double[] numbersToMultiply, int numbersInputed)
        {
            double tempMultiply = 1;

            for (int i = 0; i < numbersToMultiply.Length; i++)
            {
                tempMultiply = tempMultiply * numbersToMultiply[i];
            }

            Console.WriteLine("The multiplication of your " + numbersInputed + " numbers is " + tempMultiply);
            return tempMultiply;
        }

        static double Divide(double[] numbersToDivide, int numbersInputed)
        {
            double tempDivide = numbersToDivide[0];

            for (int i = 1; i < numbersToDivide.Length; i++)
            {
                tempDivide = tempDivide / numbersToDivide[i];
            }

            Console.WriteLine("The division of your " + numbersInputed + " numbers is " + tempDivide);
            return tempDivide;
        }

    }
}
