namespace Calculator
{
    public static class Methods
    {
        public static void AddMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne + numTwo) + "!");
            Console.Read();
        }
        public static void SubMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne - numTwo) + "!");
            Console.Read();
        }
        public static void DivideMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne / numTwo) + "!");
            Console.Read();
        }
        public static void MultiplyMethod(int numOne, int numTwo)
        {
            Console.WriteLine("your number is " + (numOne * numTwo) + "!");
            Thread.Sleep(1000);
            Console.WriteLine("type exit to close program, or type continue!");
            string testInput = Console.ReadLine();
            
            if (testInput == "exit")
            {
                Environment.Exit(0);
            }
            else if (testInput == "continue")
            {
                string[] validCommands = { "add", "subtract", "divide", "multiply" };
                TestMethod(validCommands);
            }

            //Console.Read();
        }
        public static int EnterNumber(string numberSequence)
        {
            Console.WriteLine("Enter your " + numberSequence);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static string TestMethod(string[] validCommands)
        {
            Thread.Sleep(1000);
            Console.WriteLine("welcome to my calculator!");
            while (true)
            {
                
                Thread.Sleep(1250);
                Console.WriteLine("please enter add, subtract, divide or multiply!");
                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (Array.Exists(validCommands, x => x == userInput))
                {
                    return userInput;
                }
                else if (userInput == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("type one of those options silly! ");
                    Thread.Sleep(1250);
                }
            }
        }
    }
}