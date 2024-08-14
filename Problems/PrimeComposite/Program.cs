namespace PrimeComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number to see if its prime!");
            int uInput = Convert.ToInt32(Console.ReadLine());
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
                Console.ReadLine();
            }
        }
    }
}