using System;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            return '-';
        }

    }
}




