

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validCommands = { "add", "subtract", "divide", "multiply" };
            string userInput = TestMethod(validCommands);
            

            int numOne = EnterNumber("first number!");
            int numTwo = EnterNumber("second number!");


            switch (userInput)
            {
                case "add":
                    Methods.AddMethod(numOne, numTwo);
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
        
        



    }
}
