namespace Testing
{
    internal class Car
    {

        static void Main(string[] args)
        {
            Console.WriteLine("give me");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                TestMethod();
                Console.Read();
            }
            else
            {
                TestMethodTwo();
                Console.Read();

            }
        }
        static void TestMethod()
        {
            Console.WriteLine("TestMethod");

        }
        static void TestMethodTwo()
        {
            Console.WriteLine("TestMethodTwo is diplsayted");
        }






    }

}