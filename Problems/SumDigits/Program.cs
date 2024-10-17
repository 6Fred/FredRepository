using System.Threading.Channels;

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
        }
            

        
        
        static void SumMethod(int userInput, int totalSum)
        {
            while (userInput != 0)
            {
                totalSum += userInput % 10;
                userInput /= 10;
            }
            Console.WriteLine("the sum is " + totalSum);
            Thread.Sleep(3000);
            Console.WriteLine("i hope you're happy.");
            Thread.Sleep(3000);
            Console.WriteLine("bye");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }
            static string GreetingMethod(string[] validWords, int totalSum)
        {
            while (true)
            {
                Console.WriteLine("List digits for their total sum! ex. 1234 = 10");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(1000);
                Console.WriteLine("Wow! " + userInput + " is my favorite number!");
                Thread.Sleep(1750);
                Console.WriteLine("Are you sure you want to use this number? ");


                string uInput;


                while (true)
                {
                    uInput = Console.ReadLine()?.Trim().ToLower();

                    if (Array.Exists(validWords, x => x ==uInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("SAY YES OR NO!!!");
                    }
                }
                if (uInput == "no")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("really?");
                    Thread.Sleep(1800);
                    Console.WriteLine("wow.");
                    Thread.Sleep(1750);
                    Console.WriteLine("just wow.");
                    Thread.Sleep(1750);
                    Console.WriteLine("lame. goodbye");
                    Thread.Sleep(1750);
                    Environment.Exit(0);
                }
                Thread.Sleep(500);
                Console.WriteLine("calculating...");
                Thread.Sleep(1000);
                Console.WriteLine("almost there...");
                Thread.Sleep(2000);
                SumMethod(userInput, totalSum);

                return uInput;
               
            }   
        }






    }
}
