namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List digits for the sum of them! ex. 1234 = 10");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (userInput != 0)
            {
                sum += userInput % 10;
                userInput /= 10;
            }
            Console.WriteLine("sum of digits" + sum);
            Console.Read();




        }
    }
}
