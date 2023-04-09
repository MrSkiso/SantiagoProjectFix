using System;

namespace ParenthesisChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parentheses");
            string response = Console.ReadLine();
            int open = CountChars(response, '(');
            int close = CountChars(response, ')');
            if (open == close)
            {
                Console.WriteLine("The parentheses are closed");
            }
            else
            {
                Console.WriteLine("The parentheses are not closed");
            }
        }

        public static int CountChars(string text, char search)
        {
            int amount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                    amount++;
            }
            return amount;
        }
    }
}

