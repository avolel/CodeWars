using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = new string[] { "Andy", "Andre Volel","Tesla"};
            Console.WriteLine($"{string.Join(st)}");
        }

        private static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> output = new List<string>();
            var lstnames = names.ToList();
            foreach (var item in lstnames)
            {
                if (item.Length == 4)
                    output.Add(item);
            }

            return output;
        }
    }
}
