namespace Testing
{
    internal class Car
    {

        static void Main(string[] args)
        {
            Console.WriteLine("give me");
            string userInput = (Console.ReadLine());
            bool userResult = (userInput == "1") ? TestMethod() : TestMethodTwo();
            Console.Read();
        }
        static void TestMethod()
        {
            Console.WriteLine("blue!");

        }
        static void TestMethodTwo()
        {
            Console.WriteLine("red!");
        }






    }

}