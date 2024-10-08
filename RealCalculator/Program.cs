using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator!");
            Console.WriteLine("Please enter a number: ");
            string firstNumber = Console.ReadLine();
            int intFirstNumber = Convert.ToInt32(firstNumber);
            Console.WriteLine("What is your second number: ");
            string secondNumber = Console.ReadLine();
            int intSecondNumber = Convert.ToInt32(secondNumber);
            Console.WriteLine("What would you like to do with the two numbers?");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                int answer = intFirstNumber + intSecondNumber;
                Console.WriteLine("Your answer is: " + answer);
                Console.ReadLine();
            }

            if (operation == "-")
            {
                int answer = intFirstNumber - intSecondNumber;
                Console.WriteLine("Your answer is: " + answer);
                Console.ReadLine();
            }
            
            if (operation == "*")
            {
                int answer = intFirstNumber * intSecondNumber;
                Console.WriteLine("Your answer is: " + answer);
                Console.ReadLine();
            }

            if (operation == "/")
            {
                int answer = intFirstNumber / intSecondNumber;
                Console.WriteLine("Your answer is: " + answer);
                Console.ReadLine();
            }


        }
    }
}