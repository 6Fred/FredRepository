namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number!");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numTwo + numOne);
            Console.Read();

        }
    }
}
