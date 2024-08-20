namespace Calculator
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
                SubMethod(numOne, numTwo);
            }
            else if (userInput == "divide")
            {
                DivideMethod(numOne, numTwo);
            }
            else if (userInput == "multiply")
            {
                MultiplyMethod(numOne, numTwo);
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
        static void SubMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne - numTwo) + "!");
            Console.Read();
        }
        static void DivideMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne / numTwo) + "!");
            Console.Read();
        }
        static void MultiplyMethod(int numOne, int numTwo)
        {
            

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
