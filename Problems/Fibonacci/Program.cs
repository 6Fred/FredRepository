namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, lets do fibonacci up to 21 using a while loop!");
            Console.WriteLine("following the order of 1, 1, 2, 3, 5, 8, 13, 21, etc");

            int a = 1;
            int b = 1;
            int c = 0;
            FibMethod(a, b, c);
            Console.Read();
        }
        static void FibMethod(int a, int b, int c)
        {
            while (c < 21)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
