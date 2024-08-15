namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int userMod = userInput % 2;
            string userResult = (userMod < 1) ? "the number is even!" : "the number is odd!";
            Console.WriteLine(userResult);
            Console.Read();
        }
    }
}
