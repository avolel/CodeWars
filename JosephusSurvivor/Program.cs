using System;
using System.Collections.Generic;

namespace JosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Last Survivor {JosSurvivor(7,3)}");
        }

        private static int JosSurvivor(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (JosSurvivor(n-1,k) + k - 1) % n + 1;
        }
    }
}
