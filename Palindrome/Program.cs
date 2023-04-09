using System;
using System.Text;

namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(Palindrome(response));
        }

        public static bool Palindrome(string text)
        {
            string cleanedText = text.Replace(" ", "").ToLower();

            StringBuilder reversedText = new StringBuilder(cleanedText.Length);
            for (int i = cleanedText.Length - 1; i >= 0; i--)
            {
                reversedText.Append(cleanedText[i]);
            }

            return cleanedText == reversedText.ToString();
        }
    }
}

