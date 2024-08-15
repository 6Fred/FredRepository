namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List digits for the sum of them! ex. 1234 = 10");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int totalSum = 0;

            while (userInput != 0)
            {
                totalSum += userInput % 10;
                userInput /= 10;
            }
            Console.WriteLine("the sum is " + totalSum);
            Console.Read();
        }
    }
}
