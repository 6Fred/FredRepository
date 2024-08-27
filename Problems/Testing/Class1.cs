namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validCommands = { "add", "subtract", "divide", "multiply" };
            string userInput = "";

            while (true)
            {
                Console.WriteLine("please enter add, subtract, divide or multiply!");
                userInput = Console.ReadLine()?.Trim().ToLower();

                if (Array.Exists(validCommands, x => x == userInput))
                {
                    break;
                }
                else
                {
                    global::System.Console.WriteLine("type on of those options silly! ");
                }
            }

            int numOne = EnterNumber("first number!");
            int numTwo = EnterNumber("second number!");

            switch (userInput)
            {
                case "add":
                    AddMethod(numOne, numTwo);
                    break;
                case "subtract":
                    SubMethod(numOne, numTwo);
                    break;
                case "divide":
                    DivideMethod(numOne, numTwo);
                    break;
                case "multiply":
                    MultiplyMethod(numOne, numTwo);
                    break;
                default:
                    Console.WriteLine("choose one of those options!");
                    break;
            }
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
            Console.WriteLine("Enter your " + numberSequence);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }
    }

}
