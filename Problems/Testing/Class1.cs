using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome!");
            CountWords();


        }
        static void CountWords()
        {
            Console.WriteLine("type a sentence");
            string userSentence = Console.ReadLine();
            string[] StringArray = userSentence.Split(' ');
            int MoreThan4 = StringArray.Count(i => i.Length > 4);
            Console.WriteLine(MoreThan4);
            Console.Read();
        }

    }






}

 


   


