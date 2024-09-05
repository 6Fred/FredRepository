namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validCommands = { "add", "subtract", "divide", "multiply" };
            bool keepRunning = true;

            while (keepRunning)
            {
                string userInput = Methods.TestMethod(validCommands);

                if (userInput == "exit")
                {
                    keepRunning = false;
                    continue;
                }
                int numOne = Methods.EnterNumber("first number!");
                int numTwo = Methods.EnterNumber("second number!");

                switch (userInput)
                {
                    case "add":
                        Methods.AddMethod(numOne, numTwo);
                        break;
                    case "subtract":
                        Methods.SubMethod(numOne, numTwo);
                        break;
                    case "divide":
                        Methods.DivideMethod(numOne, numTwo);
                        break;
                    case "multiply":
                        Methods.MultiplyMethod(numOne, numTwo);
                        break;
                    default:
                        Console.WriteLine("choose one of those options!");
                        break;
                }

            }





        }
    }
}
