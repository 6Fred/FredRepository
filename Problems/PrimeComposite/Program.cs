namespace PrimeComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;

            Console.WriteLine("lets check a sum of two numbers to see if its prime!");
            Thread.Sleep(1300);
            Console.WriteLine("give me a number now!");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me another number now!");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            int uInput = numberOne + numberTwo;

            
            if (uInput == 0 || uInput == 1)
            {
                Console.WriteLine(uInput + " is not a prime number!");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= uInput/2; i++)
                {
                    if (uInput % i == 0)
                    {
                        Console.WriteLine(uInput + " is not a prime number");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine(uInput + " is a prime number!");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
        }
    }
}