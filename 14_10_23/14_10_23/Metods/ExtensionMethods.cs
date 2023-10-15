using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_23.Metods
{
    //Task 2 ve 3
    public static class ExtensionMethods
    {
        public static void IsOdd(this int number)
        {
            bool isOdd = number % 2 != 0;
            Console.WriteLine($"Tek eded {isOdd}");
        }

        public static void IsEven(this int number)
        {
            bool isEven = number % 2 == 0;
            Console.WriteLine($"Cut eded {isEven}");
        }

        public static void HasDigit(this string text)
        {
            bool hasDigit = text.Any(char.IsDigit);
            Console.WriteLine($"Textde reqem var {hasDigit}");
        }

        public static void CheckPassword(this string password)
        {
            bool checkPassword = password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
            Console.WriteLine($"Parol {checkPassword}");
        }

        public static void Capitalize(this string text)
        {
            string[] words = text.Split(' ');
            StringBuilder formattedSentence = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    formattedSentence.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ");
                }
                else
                {
                    Console.WriteLine("Sehv input");
                }
            }
            formattedSentence.Length--;

            Console.WriteLine(formattedSentence.ToString());
        }

        public static string CapitalizeText(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Sehv input");
            }

            string[] words = input.Split(' ');
            StringBuilder capitalized = new StringBuilder();

            foreach (string word in words)
            {
                if (capitalized.Length > 0)
                {
                    capitalized.Append(' ');
                }
                capitalized.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower());
            }

            return capitalized.ToString();
        }

    }
}
