using System;
using System.Linq;

namespace DetectPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine($"Is \"{str}\" a Pangram? {IsPangram(str)}");
        }

        private static bool IsPangram(string str)
        {
            return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }
    }
}
