namespace CountNumberOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a sentence in!");

            string userSentence = Console.ReadLine();

            WordCounter(userSentence);
        }

        static void WordCounter(string userSentence)
        {
            string[] wordArray = userSentence.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = wordArray.Length;

            Console.WriteLine($"The sentence contains {wordCount} words.");
            Console.Read();
        }
    }
}
