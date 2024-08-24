namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type add, subtract, divide or multiply");
            string userInput = Console.ReadLine();
            if (userInput != ("add" , "divide" , "multiply" , "subtract"))
                {
                Console.WriteLine("choose them dummy!");
            }
            else
            {
                //add soemthing here thats like a "Skip" so it moves on ( im tryingto make it to where it
                // displays a msg if add,sub,etc was NOT typed in by user
                // trying if else kinda works but wont allow add,divide,etc, but works if i just have 1 value (like only
                // add for example) in line 9!
                //good luck lol
            }
            int numOne = EnterNumber("first number!");
            int numTwo = EnterNumber("second number!");
            switch (userInput)
            {
                case "add":
                    AddMethod( numOne,  numTwo);
                    break;
                case "subtract":
                    SubMethod( numOne,  numTwo);
                    break;
                case "divide":
                    DivideMethod( numOne,  numTwo);
                    break;
                case "multiply":
                    MultiplyMethod( numOne,  numTwo);
                    break;
                default:
                    Console.WriteLine("choose one of those options switch code!");
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
