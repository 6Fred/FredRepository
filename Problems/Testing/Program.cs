namespace Testing
{
    internal class Car
    {
        string model;
        string color;
        int year;

            static void Main (string[] args)
        {
            Car Ford = new Car ();
            Ford.model = "falcon";
            Ford.color = "gay red";
            Ford.year = 1980;

            Car Fiat = new Car ();
            Fiat.model = "fiat mini";
            Fiat.color = "blue red";
            Fiat.year = 1967;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Fiat.model, Fiat.color, Fiat.year);
            Console.Read();
          
        }

    }

}