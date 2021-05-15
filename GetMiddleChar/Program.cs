using System;

namespace GetMiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The Big House is our house.";
            Console.WriteLine($"{GetMiddle(s)}");
        }

        private static string GetMiddle(string s)
        {
            string output = string.Empty;
            if (s.Length % 2 == 0)
                output = s.Substring((s.Length / 2) - 1, 2);
            else if (s.Length == 1)
                output = s;
            else
                output = Char.ToString(s.Substring(s.Length / 2, 1).ToCharArray()[0]);
            return output;
        }
    }
}
