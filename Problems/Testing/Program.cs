namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type in add, sub, div, mult");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "add":
                    AddMethod();
                    break;
                case "sub":
                    SubMethod();
                    break;
                case "div":
                    DivideMethod(); 
                    break;
                case "mult":
                    MultiplyMethod();
                    break;
                default:
                    Console.WriteLine("choose one of those options!");
                    break;
            }
        }
        static void LineMethod()
        {
            Console.WriteLine("enter a number!");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number!");
            int numTwo = Convert.ToInt32(Console.ReadLine());
        }
        static void AddMethod()
        {
            LineMethod();
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
        
    }
}
