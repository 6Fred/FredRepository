namespace Testing
{
    internal class Car
    {
        static void TestMethod(string carColor)
        {
            Console.WriteLine(carColor + " toyota");
        }
        static void Main(string[] args)
        {

            TestMethod("blue");
            TestMethod("green");
            TestMethod("red");
            Console.Read();
        }








    }

}