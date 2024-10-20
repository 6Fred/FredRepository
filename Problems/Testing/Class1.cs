namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;

            Console.WriteLine("give me a number now!");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me another number now!");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numberOne + numberTwo;

            Console.WriteLine($"{sum} is your answer! lets check if its even or odd!");
            Thread.Sleep(2000);

            
            int userMod = sum % 2;
            string userResult = (userMod < 1) ? "the number is even!" : "the number is odd!";
            Console.WriteLine(userResult);
            Console.Read();
        }
    }
}
