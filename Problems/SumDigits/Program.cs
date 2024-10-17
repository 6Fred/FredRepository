namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            string[] validWords = { "yes", "no" };
            bool keepRunning = true;

            while (keepRunning)
            {
                string uInput = GreetingMethod(validWords, totalSum);

                if (uInput == "exit")
                {
                    Environment.Exit(0);
                    continue;
                }
            } 
            
            Console.Read();
        }


            static void SumMethod(int userInput, int totalSum)
        {
            while (userInput != 0)
            {
                totalSum += userInput % 10;
                userInput /= 10;
            }
            Console.WriteLine("the sum is " + totalSum);
        }
            static string GreetingMethod(string[] validWords, int totalSum)
        {
            while (true)
            {
                Console.WriteLine("List digits for their total sum! ex. 1234 = 10");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wow! " + userInput + " is my favorite number! Are you sure you want to use this number?");
                string uInput = Console.ReadLine()?.Trim().ToLower();

                if (Array.Exists(validWords, x => x == uInput))
                {
                    SumMethod(userInput, totalSum);
                }
                else
                {
                    Console.WriteLine("SAY YES OR NO!!!");
                }
            }
        }






    }
}
