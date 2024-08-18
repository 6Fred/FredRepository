﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type add, subtract, divide or multiply");
            string userInput = Console.ReadLine();

            int numOne = EnterNumber ("first number");
            int numTwo = EnterNumber ("second number");

            if (userInput == "add")
            {
                AddMethod( numOne, numTwo);
            }
            else if (userInput == "subtract")
            {
                SubMethod();
            }
            else if (userInput == "divide")
            {
                DivideMethod();
            }
            else if (userInput == "multiply")
            {
                MultiplyMethod();
            }
            else 
            {
                Console.WriteLine("choose one of those options!");
                
            }
            Console.Read();
        }
        static void AddMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne + numTwo) + "!");
            Console.Read();
        }
        static void SubMethod()
        {
            Console.WriteLine("enter a number!");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your number is " + (numOne - numTwo) + "!");
            Console.Read();
        }
        static void DivideMethod()
        {
            Console.WriteLine("enter a number!");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your number is " + (numOne / numTwo) + "!");
            Console.Read();
        }
        static void MultiplyMethod()
        {
            Console.WriteLine("enter a number!");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your number is " + (numOne * numTwo) + "!");
            Console.Read();
        }
        static int EnterNumber(string numberSequence)
        {
            Console.WriteLine("Enter " + numberSequence);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}
