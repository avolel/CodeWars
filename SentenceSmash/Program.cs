using System;

namespace SentenceSmash
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "this", "is", "great" };
            Console.WriteLine(Smash(words).Trim());
        }

        private static string Smash(string[] words)
        {
            return String.Join(" ", words);
        }
    }
}
