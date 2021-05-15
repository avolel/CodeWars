using System;
using System.Linq;

namespace SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Test_Andre";
            var s = Solution(str);
            Console.WriteLine($"{string.Join(",", s)}");
        }

        private static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";

            return Enumerable.Range(0, str.Length / 2).Select(a => str.Substring(a * 2, 2)).ToArray();
        }
    }
}
