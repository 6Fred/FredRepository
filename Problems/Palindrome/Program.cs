namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a word to check if its a palindrome");
            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
            {
                Console.WriteLine($"{userInput} is a palindrome.");
                Console.Read();
            }
            else
            {
                Console.WriteLine($"{userInput} is NOT a palindrome.");
                Console.Read();
            }
        }
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            word = word.Replace(" ", "");

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);  
            string reversedWord = new string(charArray);

            return word == reversedWord;


        }
    }
}
